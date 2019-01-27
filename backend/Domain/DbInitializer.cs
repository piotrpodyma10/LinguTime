using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinguTime.Domain
{
    public static class DbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<LinguTimeContext>();
            context.Database.Migrate();

            if (!context.Users.Any())
            {
                context.Users.Add(new Dto.UsersDto()
                {
                    Id = "1"
                });

                context.Users.Add(new Dto.UsersDto()
                {
                    Id = "2"
                });

                context.Users.Add(new Dto.UsersDto()
                {
                    Id = "3"
                });

                context.Users.Add(new Dto.UsersDto()
                {
                    Id = "4"
                });

                context.SaveChanges();
            }

            if (!context.Category.Any())
            {
                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Work",
                    UserId = "1"
                });

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Sport",
                    UserId = "2"
                });

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "House",
                    UserId = "3"
                });

                context.SaveChanges();
            }

            if (!context.UserPoints.Any())
            {
                context.UserPoints.Add(new Dto.UserPointsDto()
                {
                   CategoryId = 1,
                   UserId = "1",
                   Score = 70
                });

                context.UserPoints.Add(new Dto.UserPointsDto()
                {
                    CategoryId = 2,
                    UserId = "2",
                    Score = 40
                });

                context.SaveChanges();
            }

            if (!context.WordMetadata.Any())
            {
                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "House",
                    Url = "https://www.porterdavis.com.au/~/media/homes/verona/22/facades/verona-island-facade-classic.jpg?w=582&amp;h=320&amp;crop=1",
                    CategoryId = 3
                });

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Football",
                    Url = "https://cdn.soccerladuma.co.za/cms2/image_manager/uploads/News/283728/7/default.jpg",
                    CategoryId = 2
                });

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Basketball",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnxkbODZOhiiZ8hNwvlCJ48qukcYLkcXFK3B5eYYAX35cVi5zZ",
                    CategoryId = 2
                });

                context.SaveChanges();
            }

            if (!context.Language.Any())
            {
                context.Language.Add(new Dto.LanguageDto()
                {
                    Name = "PL",
                });

                context.Language.Add(new Dto.LanguageDto()
                {
                    Name = "EN",
                });

                context.Language.Add(new Dto.LanguageDto()
                {
                    Name = "GE",
                });

                context.SaveChanges();
            }

            if (!context.Words.Any())
            {
                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Piłka nożna",
                    LanguageId = 1,
                    WordsMetadataId = 2
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Football",
                    LanguageId = 2,
                    WordsMetadataId = 2
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Fussball",
                    LanguageId = 3,
                    WordsMetadataId = 2
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "House",
                    LanguageId = 2,
                    WordsMetadataId = 1
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Dom",
                    LanguageId = 1,
                    WordsMetadataId = 1
                });

                context.SaveChanges();
            }

            if (!context.Examples.Any())
            {
                context.Examples.Add(new Dto.ExamplesDto()
                {
                    WordId = 1,
                    Sentence = "Kiedy gramy w piłkę nożną?"
                });

                context.SaveChanges();
            }

            if (!context.CustomWordMetadata.Any())
            {
                context.CustomWordMetadata.Add(new Dto.CustomWordMetadataDto()
                {
                    Name = "Volleyball",
                    Url = "https://i.ytimg.com/vi/h_QyTcPD1G4/maxresdefault.jpg",
                    UserId = "1",
                    CategoryId = 2
                });

                context.SaveChanges();
            }

            if (!context.CustomWords.Any())
            {
                context.CustomWords.Add(new Dto.CustomWordsDto()
                {
                    Name = "Volleyball",
                    CustomWordsMetadataId = 1,
                    LanguageId = 2,
                    CategoryId = 2
                });

                context.SaveChanges();
            }
        }
    }
}
