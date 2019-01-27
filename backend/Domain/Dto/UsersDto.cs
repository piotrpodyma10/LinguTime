using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinguTime.Domain.Dto
{
    public class UsersDto
    {
        [Key]
        public string Id { get; set; }
    }
}
