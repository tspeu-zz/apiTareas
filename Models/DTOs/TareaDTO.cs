using Api.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.DTOs
{
    class TareaDTO: BaseDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }  
        
        public User User { get; set; }

        public DateTime FinalDate { get; set; }

        public DateTime DeliveratedDate { get; set; }
        public DateTime RememberDate { get; set; }

        public bool IsCompleted { get; set; } = false;


    }
}
