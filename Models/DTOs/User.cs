using Api.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.DTOs
{
    class User: BaseDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string UserName { get; set; }

    }
}
