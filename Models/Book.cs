
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WrapUp2.Models{

    public class Book{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BookId {get; set;}
        public string BookName {get; set;}
        public string Genre {get; set;}
        public string Country {get; set;}
        public string Series {get; set;}
        
        public float BorrowPrice {get; set;}
        // [ForeignKey("ClientId")]
        public int ClientId {get; set;}
        public Client Client {get;set;}
        public List<Author> Authors {get; set;}
        
    }
}