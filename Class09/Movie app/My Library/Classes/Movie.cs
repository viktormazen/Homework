using My_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, double rating, double ticketPrice)
        {
            try
            {
                Title = title;
                Genre = genre;
                if(rating < 0 || rating > 5)
                {
                    throw new Exception();
                }
                Rating = rating;
                TicketPrice = Rating * ticketPrice;
            }
            catch (Exception)
            {
                Console.WriteLine("Rating must be between 1 to 5");
            }
            TicketPrice = Rating * ticketPrice;
        }
    }
}
