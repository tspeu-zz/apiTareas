using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Base
{
    class BaseDto
    {
       [Required]
        public int Id { get; set; }

        [Required]
        public string CreateAt { get; set; } = DateTime.Now.ToString("MM/dd/yyyy H:mm");

        [Required]
        public string ModifiedAt { get; set; } = DateTime.Now.ToString("MM/dd/yyyy H:mm");

        [Required]
        public bool IsDelete { get; set; } = false;



    }
}
