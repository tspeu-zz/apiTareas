using Api.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.DTOs
{
    class Studies: BaseDto
    {
        [Required]
        public string Value { get; set; }

        [Required]
        public string ViewValue { get; set; }

        public string Level { get; set; }




    }
}
