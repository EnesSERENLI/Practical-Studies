using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Movies2.Models.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }
    }
}