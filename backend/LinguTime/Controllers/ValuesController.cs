using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ValuesController(LinguTimeContext context)
        {
            _context = context;
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

        [HttpGet("Words-By-Category")]
        public ActionResult<IEnumerable<CategoryDto>> GetWordsByCategory(int languageId, int categoryId)
        {
            var response = _context.Words
                .Include(lang => lang.Language)
                .Where(langId => langId.LanguageId == languageId)
                .Include(wmd => wmd.WordsMetadata)
                .Where(wmdId => wmdId.WordsMetadata.CategoryId == categoryId);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("CustomWords-By-Category")]
        public ActionResult<IEnumerable<CustomWordsDto>> GetCustomWordsByCategory(int userId, int languageId, int categoryId)
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
        public ActionResult<IEnumerable<CustomWordsDto>> GetAllCustomWords(int userId)
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
        public ActionResult<IEnumerable<UserPointsDto>> GetUserPointsById(int userId)
        {
            var response = _context.UserPoints.Where(u => u.UserId == userId).Include(cat => cat.Category);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("CustomWordMetadata")]
        public ActionResult<IEnumerable<UserPointsDto>> GetCustomWordMetadata(int userId)
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

            _context.UserPoints.Add(new UserPointsDto
            {
                UserId = userPoints.UserId,
                CategoryId = userPoints.CategoryId,
                Score = userPoints.Score
            });
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

            _context.Category.Add(new CategoryDto
            {
                Name = category.Name,
                UserId = category.UserId
            });
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

            _context.CustomWordMetadata.Add(new CustomWordMetadataDto
            {
                Name = customWordMetadata.Name,
                Url = customWordMetadata.Url,
                CategoryId = customWordMetadata.CategoryId,
                UserId = customWordMetadata.UserId
            });
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

            _context.CustomWords.Add(new CustomWordsDto
            {
                Name = customWord.Name,
                CustomWordsMetadataId = customWord.CustomWordsMetadataId,
                LanguageId = customWord.LanguageId,
                CategoryId = customWord.CategoryId
            });
            _context.SaveChanges();

            return Ok();
        }


        [HttpPost("Register-User")]
        public IActionResult Register([FromBody] CreateUserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(new UsersDto
            {
                Login = user.Login,
                Password = user.Password
            });
            _context.SaveChanges();


            return Ok();
        }

        [HttpPost("Log-In-User")]
        public IActionResult LogInUser([FromBody] UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}
