using LinguTime.Domain.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinguTime.Domain
{
    public class LinguTimeContext : DbContext
    {
        public LinguTimeContext(DbContextOptions<LinguTimeContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPointsDto>().HasKey(up => new { up.CategoryId, up.UserId });
        }

        public DbSet<CategoryDto> Category { get; set; }
        public DbSet<CustomWordMetadataDto> CustomWordMetadata { get; set; }
        public DbSet<CustomWordsDto> CustomWords { get; set; }
        public DbSet<ExamplesDto> Examples { get; set; }
        public DbSet<LanguageDto> Language { get; set; }
        public DbSet<UserPointsDto> UserPoints { get; set; }
        public DbSet<UsersDto> Users { get; set; }
        public DbSet<WordMetadataDto> WordMetadata { get; set; }
        public DbSet<WordsDto> Words { get; set; }
    }
}
