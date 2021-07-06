
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WrapUp2.Models
{

    public class BookDTO
    {

        public string BookName { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public string Series { get; set; }

        public float BorrowPrice { get; set; }


    }
}