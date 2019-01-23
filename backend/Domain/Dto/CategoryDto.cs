using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinguTime.Domain.Dto
{
    public class CategoryDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        //public UsersDto Users { get; set; }

        //public IList<UserPointsDto> UserPoints { get; set; }
    }
}
