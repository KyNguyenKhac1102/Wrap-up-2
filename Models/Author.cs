using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WrapUp2.Models{

    public class Author{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AuthorId {get; set;}
        public string FristName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfBirth {get; set;}
        
        public List<Book> Books {get; set;} 
    }
}