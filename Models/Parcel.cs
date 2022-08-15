using System;
using System.ComponentModel.DataAnnotations;

namespace test_backend.Models
{
    public class Parcel
    {
        [Key]
        public int id { get; set; }
        public string WKT { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Neighbourhood { get; set; }
    }
}

