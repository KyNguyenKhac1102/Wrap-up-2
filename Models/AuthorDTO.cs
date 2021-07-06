using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WrapUp2.Models
{

    public class AuthorDTO
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        
    }
}