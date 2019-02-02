using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;



namespace LinguTime.Domain.Dto
{
    public class UserPointsDto
    {
        [ForeignKey("User")]
        public string UserId { get; set; }
        public UsersDto User { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public int Score { get; set; }
    }
}
