using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinguTime.Domain;
using LinguTime.Domain.Dto;
using LinguTime.Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinguTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly LinguTimeContext _context;
        private readonly IMapper _mapper;

        public ValuesController(LinguTimeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("Languages")]
        public ActionResult<IEnumerable<LanguageDto>> GetLanguages()
        {
            var response = _context.Language;

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("Language-To-Learn")]
        public ActionResult<IEnumerable<LanguageDto>> GetLanguageToLearn(int languageId)
        {
            var response = _context.Language.Where(lang => lang.Id != languageId);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("Categories")]
        public ActionResult<IEnumerable<CategoryDto>> GetCategories()
        {
            var response = _context.Category;

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("Category-By-Id")]
        public ActionResult<IEnumerable<CategoryDto>> GetCategoryById(int id)
        {
            var response = _context.Category.Where(cat => cat.Id == id);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("Flash-Cards")]
        public ActionResult<IEnumerable<FlashCardsContainerViewModel>> GetWordsByCategory(int mainLanguageId, int languageToLearnId, int categoryId)
        {
            var mainLanguage = from wordMetadata in _context.WordMetadata
                               join words in _context.Words
                               on wordMetadata.Id equals words.WordsMetadataId
                               join category in _context.Category
                               on wordMetadata.CategoryId equals category.Id
                               where words.LanguageId == mainLanguageId && wordMetadata.CategoryId == categoryId
                               select new WordsDto
                               {
                                   Name = words.Name,
                                   WordsMetadataId = words.WordsMetadataId,
                                   WordsMetadata = new WordMetadataDto
                                   {
                                       Category = new CategoryDto
                                       {
                                           Name = category.Name
                                       }
                                   }
                               };

            var languageToLearn = from wordMetadata in _context.WordMetadata
                                  join words in _context.Words
                                  on wordMetadata.Id equals words.WordsMetadataId
                                  where words.LanguageId == languageToLearnId && wordMetadata.CategoryId == categoryId
                                  select new WordsDto
                                  {
                                      WordsMetadataId = wordMetadata.Id,
                                      Name = words.Name,
                                      WordsMetadata = new WordMetadataDto
                                      {
                                          Url = wordMetadata.Url
                                      }
                                  };

            var otherWords = from wordMetadata in _context.WordMetadata
                             join words in _context.Words
                             on wordMetadata.Id equals words.WordsMetadataId
                             where words.LanguageId == languageToLearnId
                             select new WordsDto
                             {
                                 WordsMetadataId = wordMetadata.Id,
                                 Name = words.Name,
                                 WordsMetadata = new WordMetadataDto
                                 {
                                     Url = wordMetadata.Url
                                 }
                             };

            List<FlashCardsViewModel> flashCards = new List<FlashCardsViewModel>();

            foreach (var iterator in mainLanguage)
            {
                var currentLanguageToLearn = languageToLearn.Where(x => x.WordsMetadataId == iterator.WordsMetadataId);
                List<FlashCardsWordsViewModel> words = new List<FlashCardsWordsViewModel>();

                words.Add(new FlashCardsWordsViewModel()
                {
                    wordName = currentLanguageToLearn.Select(x => x.Name).Single(),
                    img = currentLanguageToLearn.Select(x => x.WordsMetadata.Url).Single(),
                    correctWord = true,
                });

                Random rnd = new Random();
                foreach (var secondIterator in otherWords.Where(x => x.WordsMetadataId != iterator.WordsMetadataId).OrderBy(x => rnd.Next()).Take(5))
                {
                    words.Add(new FlashCardsWordsViewModel()
                    {
                        wordName = secondIterator.Name,
                        correctWord = false,
                        img = secondIterator.WordsMetadata.Url
                    });
                };

                int indexPosition = rnd.Next(6);
                var element = words[0];
                words.RemoveAt(0);
                words.Insert(indexPosition, element);

                flashCards.Add(
                    new FlashCardsViewModel()
                    {
                        WordInMainLanguage = iterator.Name,
                        Words = words,
                    }
                );
            }

            var result = new FlashCardsContainerViewModel
            {
                CategoryName = mainLanguage.Select(x => x.WordsMetadata.Category.Name).FirstOrDefault(),
                NumberOfWords = flashCards.Count(),
                FlashCards = flashCards
            };

            return Ok(result);
        }

        [HttpGet("CustomWords-By-Category")]
        public ActionResult<IEnumerable<CustomWordsDto>> GetCustomWordsByCategory(string userId, int languageId, int categoryId)
        {
            var response = _context.CustomWords
                .Include(lang => lang.Language)
                .Where(langId => langId.LanguageId == languageId)
                .Include(wmd => wmd.CustomWordsMetadata)
                .Where(wmd => wmd.CustomWordsMetadata.CategoryId == categoryId && wmd.CustomWordsMetadata.UserId == userId);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("AllCustomWords-By-User")]
        public ActionResult<IEnumerable<CustomWordsDto>> GetAllCustomWords(string userId)
        {
            var response = _context.CustomWords
                .Include(lang => lang.Language)
                .Include(wmd => wmd.CustomWordsMetadata)
                .Where(wmd => wmd.CustomWordsMetadata.UserId == userId);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("UserPoints-By-UserId")]
        public ActionResult<IEnumerable<UserPointsDto>> GetUserPointsById(string userId)
        {
            var response = _context.UserPoints.Where(u => u.UserId == userId).Include(cat => cat.Category);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("CustomWordMetadata")]
        public ActionResult<IEnumerable<UserPointsDto>> GetCustomWordMetadata(string userId)
        {
            var response = _context.CustomWordMetadata.Where(u => u.UserId == userId).Include(cat => cat.Category);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }


        [HttpPost("UserPoints")]
        public IActionResult AddUserPoints([FromBody] UserPointsViewModel userPoints)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _mapper.Map<UserPointsDto>(userPoints);
            _context.UserPoints.Add(result);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("Category")]
        public IActionResult AddNewCategory([FromBody] CategoryViewModel category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _mapper.Map<CategoryDto>(category);
            _context.Category.Add(result);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("CustomWordMetadata")]
        public IActionResult AddNewCustomWordMetadata([FromBody] CustomWordMetadataViewModel customWordMetadata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _mapper.Map<CustomWordMetadataDto>(customWordMetadata);
            _context.CustomWordMetadata.Add(result);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("CustomWord")]
        public IActionResult AddNewCustomWord([FromBody] CustomWordViewModel customWord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _mapper.Map<CustomWordsDto>(customWord);
            _context.CustomWords.Add(result);
            _context.SaveChanges();

            return Ok();
        }
    }
}
