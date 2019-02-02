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
                    UserId = "1",
                    Img = "https://c1.staticflickr.com/5/4222/34127848854_7e644fbe4e_b.jpg"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Sport",
                    UserId = "2",
                    Img = "http://www.4usky.com/data/out/35/164299054-football-wallpapers.jpg"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "House",
                    UserId = "3",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUdap0MzFOCZ-b2AzEGQ5ew0Z9rRl7lKXWDf3g2ZDl8yidCQmZ"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Food",
                    UserId = "3",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmOY5RgohhF86sPk0zsR8rqLfNRJtIpDsfAOvkZh58f7uPKbsWGA"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Days",
                    UserId = "3",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQKccmGRquN-HzcrKWGCnrWQOrNNnnuLhebvrEOf1gqzxRfnDSrg"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Months",
                    UserId = "3",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLSekW7v0BsiTAhvxLJXJSRFCU6dEhNPi9x08H3xJcTylq9mIo"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Animals",
                    UserId = "2",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZ0eq9EXh9C6SORUi6mrJ6G3x9U9WSbiWdjIJWodYhqAD-eFF1"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Countries",
                    UserId = "2",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQFrFixwXAqC6ZG-ttKEuB14Cud9nVyOZKVsLO-8IdJPtreWYGJ"
                });

                context.SaveChanges();

                context.Category.Add(new Dto.CategoryDto()
                {
                    Name = "Colors",
                    UserId = "2",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeViP6xyXQWjf1pXai2M13y4E0zwXXdjnJ6j86dDdvmf_qeRJ3"
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

                context.UserPoints.Add(new Dto.UserPointsDto()
                {
                    CategoryId = 2,
                    UserId = "1",
                    Score = 35
                });

                context.UserPoints.Add(new Dto.UserPointsDto()
                {
                    CategoryId = 3,
                    UserId = "1",
                    Score = 82
                });

                context.UserPoints.Add(new Dto.UserPointsDto()
                {
                    CategoryId = 4,
                    UserId = "2",
                    Score = 75
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

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Football",
                    Url = "https://cdn.soccerladuma.co.za/cms2/image_manager/uploads/News/283728/7/default.jpg",
                    CategoryId = 2
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Basketball",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnxkbODZOhiiZ8hNwvlCJ48qukcYLkcXFK3B5eYYAX35cVi5zZ",
                    CategoryId = 2
                });

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Boxing",
                    Url = "https://i.eurosport.com/2018/09/23/2424991-50398590-2560-1440.jpg?w=1050",
                    CategoryId = 2
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Dancing",
                    Url = "https://dancemagazine.com.au/wp-content/uploads/2015/08/Dirty-Dancing-Kirby-Burgess-as-Baby-and-Kurt-Phelan-as-Johnny-in-Final-Scene.-Photo-by-Jeff-Busby.jpg",
                    CategoryId = 2
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Swimming",
                    Url = "https://cdn.swimswam.com/wp-content/uploads/2017/01/16x9_8.jpg",
                    CategoryId = 2
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Karate",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRREe3abQWyc_ayL8QUYnGrMr6RTWgHNIToJo9rMrUUxwybDUCLbA",
                    CategoryId = 2
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Ski",
                    Url = "https://cdn.cnn.com/cnnnext/dam/assets/171207160725-best-private-ski-resorts-cimarron-3.jpg",
                    CategoryId = 2
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Chess",
                    Url = "https://images.unsplash.com/photo-1536743939714-23ec5ac2dbae?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1000&q=80",
                    CategoryId = 2
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Monday",
                    Url = "https://healthyeaton.com/wp-content/uploads/2016/08/ill-start-again-on-monday.jpg",
                    CategoryId = 5
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Tuesday",
                    Url = "https://www.thefactsite.com/wp-content/uploads/2017/07/tuesday-facts.jpg",
                    CategoryId = 5
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Wednesday",
                    Url = "http://www.premiumwishes.com/wp-content/uploads/2018/07/233.jpg",
                    CategoryId = 5
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Thursday",
                    Url = "https://i.ytimg.com/vi/9I-CORTWgyM/maxresdefault.jpg",
                    CategoryId = 5
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Friday",
                    Url = "http://www.crossfitmagnolia.com/wp-content/uploads/2018/01/weekend.png",
                    CategoryId = 5
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Saturday",
                    Url = "https://goodlucksymbols.com/wp-content/uploads/2017/01/Saturday-superstitions.jpg",
                    CategoryId = 5
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Sunday",
                    Url = "http://newsmobile.in/wp-content/uploads/2018/10/shutterstock-378479302-27-1480221154.jpg",
                    CategoryId = 5
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "January",
                    Url = "https://lcrmarion.org/wp-content/uploads/2015/12/january.jpg",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "February",
                    Url = "https://tropicana.net/wp-content/uploads/2017/01/18573-AC-Jan-Feb-Blog-Images-SO-940X3682.jpg",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "March",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS8W2AkjUnkTtpE7XTSd3QQUet5_gsmulUYE1j3li6-UDJ9B1vsCw",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "April",
                    Url = "http://www.cjsrecruitment.com/assets/wp-content/uploads/2018/04/April.jpg",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "May",
                    Url = "https://c.tadst.com/gfx/1200x630/the-month-may.jpg?1",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "June",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS552uwrn8JNnSALznekrVT-hVr4UIVI2KFIxQC1JwP_TwL6zUw",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "July",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSb_iJGVSCB_ZAH1U1nah7v8ab9y-vdOtWQI6T0aYwqXPT9W2WtNQ",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "August",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmZ7hbxxgqUn7M6tBP9XhOgK_YIC9UVBx45AVKPDuKNOm8WFl6",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "September",
                    Url = "https://www.hellowoodlands.com/wp-content/uploads/2018/08/Hello-September-660x400.jpg",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "October",
                    Url = "http://www.anfocal.ie/wp-content/uploads/2018/10/PxbFtbM.jpg",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "November",
                    Url = "https://c.tadst.com/gfx/1200x630/the-month-november.jpg?1",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "December",
                    Url = "https://www.parcprovence.com/wp-content/uploads/2017/12/December.jpg",
                    CategoryId = 6
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Black",
                    Url = "https://www.standoutstickers.com/cp/Stand_Out_Stickers/html/img/decals/10.png",
                    CategoryId = 9
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "White",
                    Url = "https://www.thesprucepets.com/thmb/5Z5WAqlqp0um9gWQ4KmFwlpfmbA=/450x0/filters:no_upscale():max_bytes(150000):strip_icc()/twenty20_e47b3798-dd9b-40b1-91ef-1d820337966e-5aa3f798642dca00363b0df1.jpg",
                    CategoryId = 9
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Red",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREmUIiOqpsrvSBNklBdpSlLdsoETBerjAhdGKqxGgBZft8jTarnA",
                    CategoryId = 9
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Green",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqiWh8E1Yl-6b-IXA_9KihV4eJ7xBzFlhnavFC_Di9C60gG5cY",
                    CategoryId = 9
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Blue",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQW0jD73CeDaPWMjXRehbG1Cc3_EKLVyqRVRJLfuSBsPtC7R51G",
                    CategoryId = 9
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Time",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCRBppwQL0J3ktnssCs1tPd6uZXZMG6WSCOnGbomMhe6iEE_h",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Computer",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTr9kSoxjl9zWIblL3J9v72vH6Sv-gRB8wb2xTUxz6u0nMMfhQr",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Programmer",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSktLMIfJkiTdAuaYUGTfh9oS4belG3ke84QI2CZwaHtnmvyCI5KQ",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Office",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcToBi3JTDBMSEBcooRDCFcqjCl5HCgeA_iriOPWjVuukE4Cg6Lt",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Leader",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQriQb1JX3G_hjhEnhn-owsv53H8ID_V-MJDxKKc0CNFIdBWUo",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Money",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgYcrA6WAYdNmJtHQdVc_4KlzB5usu8yVMHMgQlcaQd94Hk_FqyQ",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Door",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRq0IGVM0taGwgAc6YAYBVYcl1u4ji33h8F-fqdwpQ2EXrljScWA",
                    CategoryId = 3
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Garage",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTN_gUfcaGUUYWFBcvAAjtQ75ue9PIL1bgz-oWPW8DPolfNE4cqbA",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Window",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRETKtQLaJEpFlm97UvmbCBVOeOPjzo21VLxMGbE9zrvVBSMuIo",
                    CategoryId = 1
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Poland",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTwwEo_YSGRVvQSnu3yW1EzlziLK6M4UnXiOQYSMgLpwa36utr",
                    CategoryId = 8
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Spain",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReOkp36ZNUvBNF9y8PbF90dfIYRbvPEiNiAJ39IPoLYLRer3wh",
                    CategoryId = 8
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Water",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR3XjZwr_j8VLR5hAwBAXgk0ibmPNzDyZK8JE2HaGd6lPdprksgxQ",
                    CategoryId = 4
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Coffee",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_KWlQQdgPdvg-w5K-DVY8Dcaln6oPuRhWMSJVJNZaxT1nw3lEFA",
                    CategoryId = 4
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Dog",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJypswOfmodG4zI2sNejeSKQwDty675iPtr-xxas2eoMZ9orY",
                    CategoryId = 7
                });

                context.SaveChanges();

                context.WordMetadata.Add(new Dto.WordMetadataDto()
                {
                    Name = "Cat",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1bUiy5vrsbPJRcXaWjQXHUmD65o3196DpgB_nY95Lmmohmzmh",
                    CategoryId = 7
                });

                context.SaveChanges();
            }

            if (!context.Language.Any())
            {
                context.Language.Add(new Dto.LanguageDto()
                {
                    Name = "Polish",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS32f98_MjrQGbAukbUDwfX2GcUFn9Kk-9cCrVnexz4cn2M-cTC"
                });

                context.SaveChanges();

                context.Language.Add(new Dto.LanguageDto()
                {
                    Name = "English",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTn1k4g7WJVd6LSjnDi02_7HSLMDDhteensvVxUSHEq5bzcVPw2lA"
                });

                context.SaveChanges();

                context.Language.Add(new Dto.LanguageDto()
                {
                    Name = "German",
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3yY9SIKGo90E0RN6gQZqvufwIbqwgDbxwoz4lnWqyrPGRvp8j"
                });

                context.SaveChanges();

                context.Language.Add(new Dto.LanguageDto()
                {
                    Name = "Spanish",
                    Img = "data:image/png;base64,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"
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
                    Name = "El Futbol",
                    LanguageId = 4,
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

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Haus",
                    LanguageId = 3,
                    WordsMetadataId = 1
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "la Casa",
                    LanguageId = 4,
                    WordsMetadataId = 1
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Koszykówka",
                    LanguageId = 1,
                    WordsMetadataId = 3
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Basketball",
                    LanguageId = 2,
                    WordsMetadataId = 3
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "die Basketball",
                    LanguageId = 3,
                    WordsMetadataId = 3
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Baloncesto",
                    LanguageId = 4,
                    WordsMetadataId = 3
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Boks",
                    LanguageId = 1,
                    WordsMetadataId = 4
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Boxing",
                    LanguageId = 2,
                    WordsMetadataId = 4
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Boxen",
                    LanguageId = 3,
                    WordsMetadataId = 4
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Boxeo",
                    LanguageId = 4,
                    WordsMetadataId = 4
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Taniec",
                    LanguageId = 1,
                    WordsMetadataId = 5
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Dancing",
                    LanguageId = 2,
                    WordsMetadataId = 5
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Tanz",
                    LanguageId = 3,
                    WordsMetadataId = 5
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "la Danza",
                    LanguageId = 4,
                    WordsMetadataId = 5
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Pływanie",
                    LanguageId = 1,
                    WordsMetadataId = 6
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Swimming",
                    LanguageId = 2,
                    WordsMetadataId = 6
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Schwimmen",
                    LanguageId = 3,
                    WordsMetadataId = 6
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Natación",
                    LanguageId = 4,
                    WordsMetadataId = 6
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Karate",
                    LanguageId = 1,
                    WordsMetadataId = 7
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Karate",
                    LanguageId = 2,
                    WordsMetadataId = 7
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Karate",
                    LanguageId = 3,
                    WordsMetadataId = 7
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Karate",
                    LanguageId = 4,
                    WordsMetadataId = 7
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Narciarstwo",
                    LanguageId = 1,
                    WordsMetadataId = 8
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Ski",
                    LanguageId = 2,
                    WordsMetadataId = 8
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Skier",
                    LanguageId = 3,
                    WordsMetadataId = 8
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Esquís",
                    LanguageId = 4,
                    WordsMetadataId = 8
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Szachy",
                    LanguageId = 1,
                    WordsMetadataId = 9
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Chess",
                    LanguageId = 2,
                    WordsMetadataId = 9
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Schachspiel",
                    LanguageId = 3,
                    WordsMetadataId = 9
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Ajedrez",
                    LanguageId = 4,
                    WordsMetadataId = 9
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Poniedziałek",
                    LanguageId = 1,
                    WordsMetadataId = 10
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Monday",
                    LanguageId = 2,
                    WordsMetadataId = 10
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Montag",
                    LanguageId = 3,
                    WordsMetadataId = 10
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Lunes",
                    LanguageId = 4,
                    WordsMetadataId = 10
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Wtorek",
                    LanguageId = 1,
                    WordsMetadataId = 11
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Tuesday",
                    LanguageId = 2,
                    WordsMetadataId = 11
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Dienstag",
                    LanguageId = 3,
                    WordsMetadataId = 11
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Martes",
                    LanguageId = 4,
                    WordsMetadataId = 11
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Środa",
                    LanguageId = 1,
                    WordsMetadataId = 12
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Wednesday",
                    LanguageId = 2,
                    WordsMetadataId = 12
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Mittwoch",
                    LanguageId = 3,
                    WordsMetadataId = 12
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Miércoles",
                    LanguageId = 4,
                    WordsMetadataId = 12
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Thursday",
                    LanguageId = 2,
                    WordsMetadataId = 13
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Donnerstag",
                    LanguageId = 3,
                    WordsMetadataId = 13
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Czwartek",
                    LanguageId = 1,
                    WordsMetadataId = 13
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Jueves",
                    LanguageId = 4,
                    WordsMetadataId = 13
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Friday",
                    LanguageId = 2,
                    WordsMetadataId = 14
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Piątek",
                    LanguageId = 1,
                    WordsMetadataId = 14
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Freitag",
                    LanguageId = 3,
                    WordsMetadataId = 14
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Viernes",
                    LanguageId = 4,
                    WordsMetadataId = 14
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Sobota",
                    LanguageId = 1,
                    WordsMetadataId = 15
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Saturday",
                    LanguageId = 2,
                    WordsMetadataId = 15
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Samstag",
                    LanguageId = 3,
                    WordsMetadataId = 15
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Sábado",
                    LanguageId = 4,
                    WordsMetadataId = 15
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Niedziela",
                    LanguageId = 1,
                    WordsMetadataId = 16
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Sunday",
                    LanguageId = 2,
                    WordsMetadataId = 16
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Sonntag",
                    LanguageId = 3,
                    WordsMetadataId = 16
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Domingo",
                    LanguageId = 4,
                    WordsMetadataId = 16
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Styczeń",
                    LanguageId = 1,
                    WordsMetadataId = 17
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "January",
                    LanguageId = 2,
                    WordsMetadataId = 17
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Januar",
                    LanguageId = 3,
                    WordsMetadataId = 17
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Enero",
                    LanguageId = 4,
                    WordsMetadataId = 17
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Luty",
                    LanguageId = 1,
                    WordsMetadataId = 18
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "February",
                    LanguageId = 2,
                    WordsMetadataId = 18
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Februar",
                    LanguageId = 3,
                    WordsMetadataId = 18
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Febrero",
                    LanguageId = 4,
                    WordsMetadataId = 18
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Marzec",
                    LanguageId = 1,
                    WordsMetadataId = 19
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "March",
                    LanguageId = 2,
                    WordsMetadataId = 19
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das März",
                    LanguageId = 3,
                    WordsMetadataId = 19
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Marzo",
                    LanguageId = 4,
                    WordsMetadataId = 19
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Kwiecień",
                    LanguageId = 1,
                    WordsMetadataId = 20
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "April",
                    LanguageId = 2,
                    WordsMetadataId = 20
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der April",
                    LanguageId = 3,
                    WordsMetadataId = 20
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Abril",
                    LanguageId = 4,
                    WordsMetadataId = 20
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Maj",
                    LanguageId = 1,
                    WordsMetadataId = 21
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "May",
                    LanguageId = 2,
                    WordsMetadataId = 21
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Mai",
                    LanguageId = 3,
                    WordsMetadataId = 21
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Mayo",
                    LanguageId = 4,
                    WordsMetadataId = 21
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Czerwiec",
                    LanguageId = 1,
                    WordsMetadataId = 22
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "June",
                    LanguageId = 2,
                    WordsMetadataId = 22
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Juni",
                    LanguageId = 3,
                    WordsMetadataId = 22
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Junio",
                    LanguageId = 4,
                    WordsMetadataId = 22
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Lipiec",
                    LanguageId = 1,
                    WordsMetadataId = 23
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "July",
                    LanguageId = 2,
                    WordsMetadataId = 23
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Juli",
                    LanguageId = 3,
                    WordsMetadataId = 23
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Julio",
                    LanguageId = 4,
                    WordsMetadataId = 23
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Sierpień",
                    LanguageId = 1,
                    WordsMetadataId = 24
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "August",
                    LanguageId = 2,
                    WordsMetadataId = 24
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "die August",
                    LanguageId = 3,
                    WordsMetadataId = 24
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Agosto",
                    LanguageId = 4,
                    WordsMetadataId = 24
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Wrzesień",
                    LanguageId = 1,
                    WordsMetadataId = 25
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "September",
                    LanguageId = 2,
                    WordsMetadataId = 25
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Septiembre",
                    LanguageId = 4,
                    WordsMetadataId = 25
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der September",
                    LanguageId = 3,
                    WordsMetadataId = 25
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Październik",
                    LanguageId = 1,
                    WordsMetadataId = 26
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "October",
                    LanguageId = 2,
                    WordsMetadataId = 26
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Oktober",
                    LanguageId = 3,
                    WordsMetadataId = 26
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Octubre",
                    LanguageId = 4,
                    WordsMetadataId = 26
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Listopad",
                    LanguageId = 1,
                    WordsMetadataId = 27
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "November",
                    LanguageId = 2,
                    WordsMetadataId = 27
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der November",
                    LanguageId = 3,
                    WordsMetadataId = 27
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Noviembre",
                    LanguageId = 4,
                    WordsMetadataId = 27
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Grudzień",
                    LanguageId = 1,
                    WordsMetadataId = 28
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "December",
                    LanguageId = 2,
                    WordsMetadataId = 28
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Dezember",
                    LanguageId = 3,
                    WordsMetadataId = 28
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Diciembre",
                    LanguageId = 4,
                    WordsMetadataId = 28
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Czarny",
                    LanguageId = 1,
                    WordsMetadataId = 29
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Black",
                    LanguageId = 2,
                    WordsMetadataId = 29
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Schwarz",
                    LanguageId = 3,
                    WordsMetadataId = 29
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Negro",
                    LanguageId = 4,
                    WordsMetadataId = 29
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Biały",
                    LanguageId = 1,
                    WordsMetadataId = 30
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "White",
                    LanguageId = 2,
                    WordsMetadataId = 30
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Weiß",
                    LanguageId = 3,
                    WordsMetadataId = 30
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Blanco",
                    LanguageId = 4,
                    WordsMetadataId = 30
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Czerwony",
                    LanguageId = 1,
                    WordsMetadataId = 31
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Red",
                    LanguageId = 2,
                    WordsMetadataId = 31
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Rot",
                    LanguageId = 3,
                    WordsMetadataId = 31
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Rojo",
                    LanguageId = 4,
                    WordsMetadataId = 31
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Zielony",
                    LanguageId = 1,
                    WordsMetadataId = 32
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Green",
                    LanguageId = 2,
                    WordsMetadataId = 32
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Grün",
                    LanguageId = 3,
                    WordsMetadataId = 32
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Verde",
                    LanguageId = 4,
                    WordsMetadataId = 32
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Niebieski",
                    LanguageId = 1,
                    WordsMetadataId = 33
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Blue",
                    LanguageId = 2,
                    WordsMetadataId = 33
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Blau",
                    LanguageId = 3,
                    WordsMetadataId = 33
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Azul",
                    LanguageId = 4,
                    WordsMetadataId = 33
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Czas",
                    LanguageId = 1,
                    WordsMetadataId = 34
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Time",
                    LanguageId = 2,
                    WordsMetadataId = 34
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "die Zeit",
                    LanguageId = 3,
                    WordsMetadataId = 34
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Tiempo",
                    LanguageId = 4,
                    WordsMetadataId = 34
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Komputer",
                    LanguageId = 1,
                    WordsMetadataId = 35
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Computer",
                    LanguageId = 2,
                    WordsMetadataId = 35
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Computer",
                    LanguageId = 3,
                    WordsMetadataId = 35
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "la Computadora",
                    LanguageId = 4,
                    WordsMetadataId = 35
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Programista",
                    LanguageId = 1,
                    WordsMetadataId = 36
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Programmer",
                    LanguageId = 2,
                    WordsMetadataId = 36
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Programmierer",
                    LanguageId = 3,
                    WordsMetadataId = 36
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Programador",
                    LanguageId = 4,
                    WordsMetadataId = 36
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Biuro",
                    LanguageId = 1,
                    WordsMetadataId = 37
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Office",
                    LanguageId = 2,
                    WordsMetadataId = 37
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Büro",
                    LanguageId = 3,
                    WordsMetadataId = 37
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "la Oficina",
                    LanguageId = 4,
                    WordsMetadataId = 37
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Lider",
                    LanguageId = 1,
                    WordsMetadataId = 38
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Leader",
                    LanguageId = 2,
                    WordsMetadataId = 38
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Leader",
                    LanguageId = 3,
                    WordsMetadataId = 38
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Líder",
                    LanguageId = 4,
                    WordsMetadataId = 38
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Pieniądze",
                    LanguageId = 1,
                    WordsMetadataId = 39
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Money",
                    LanguageId = 2,
                    WordsMetadataId = 39
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Geld",
                    LanguageId = 3,
                    WordsMetadataId = 39
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Dinero",
                    LanguageId = 4,
                    WordsMetadataId = 39
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Drzwi",
                    LanguageId = 1,
                    WordsMetadataId = 40
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Door",
                    LanguageId = 2,
                    WordsMetadataId = 40
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "die Tür",
                    LanguageId = 3,
                    WordsMetadataId = 40
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "la Puerta",
                    LanguageId = 4,
                    WordsMetadataId = 40
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Garaż",
                    LanguageId = 1,
                    WordsMetadataId = 41
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Garage",
                    LanguageId = 2,
                    WordsMetadataId = 41
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "die Garage",
                    LanguageId = 3,
                    WordsMetadataId = 41
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Garaje",
                    LanguageId = 4,
                    WordsMetadataId = 41
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Okno",
                    LanguageId = 1,
                    WordsMetadataId = 42
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Window",
                    LanguageId = 2,
                    WordsMetadataId = 42
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "die Fenster",
                    LanguageId = 3,
                    WordsMetadataId = 42
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "las Ventana",
                    LanguageId = 4,
                    WordsMetadataId = 42
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Polska",
                    LanguageId = 1,
                    WordsMetadataId = 43
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Poland",
                    LanguageId = 2,
                    WordsMetadataId = 43
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Polen",
                    LanguageId = 3,
                    WordsMetadataId = 43
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "las Polonia",
                    LanguageId = 4,
                    WordsMetadataId = 43
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Hiszpania",
                    LanguageId = 1,
                    WordsMetadataId = 44
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Spain",
                    LanguageId = 2,
                    WordsMetadataId = 44
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Spanien",
                    LanguageId = 3,
                    WordsMetadataId = 44
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "España",
                    LanguageId = 4,
                    WordsMetadataId = 44
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Woda",
                    LanguageId = 1,
                    WordsMetadataId = 45
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Water",
                    LanguageId = 2,
                    WordsMetadataId = 45
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "das Wasser",
                    LanguageId = 3,
                    WordsMetadataId = 45
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "las Aqua",
                    LanguageId = 4,
                    WordsMetadataId = 45
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Kawa",
                    LanguageId = 1,
                    WordsMetadataId = 46
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Coffee",
                    LanguageId = 2,
                    WordsMetadataId = 46
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Kaffee",
                    LanguageId = 3,
                    WordsMetadataId = 46
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Café",
                    LanguageId = 4,
                    WordsMetadataId = 46
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Pies",
                    LanguageId = 1,
                    WordsMetadataId = 47
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Dog",
                    LanguageId = 2,
                    WordsMetadataId = 47
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "der Hund",
                    LanguageId = 3,
                    WordsMetadataId = 47
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Perro",
                    LanguageId = 4,
                    WordsMetadataId = 47
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Kot",
                    LanguageId = 1,
                    WordsMetadataId = 48
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "Cat",
                    LanguageId = 2,
                    WordsMetadataId = 48
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "die Katze",
                    LanguageId = 3,
                    WordsMetadataId = 48
                });

                context.Words.Add(new Dto.WordsDto()
                {
                    Name = "el Gato / la Gata",
                    LanguageId = 4,
                    WordsMetadataId = 48
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
