using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WrapUp2.Models{
    public class Client{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ClientId {get; set;}
        public string ClientName {get; set;}
        public string Address {get; set;}
        public string Email {get; set;}
        public List<Book> Books {get;set;} 
    }
}