using System;
using System.ComponentModel.DataAnnotations;
namespace csgregslist.Models
{
    public class Cars
    {
        public string Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }

        public Cars(string id, string model, int year, double price, string description)
        {
            Id = id;
            Model = model;
            Year = year;
            Price = price;
            Description = description;

        }
    }
}