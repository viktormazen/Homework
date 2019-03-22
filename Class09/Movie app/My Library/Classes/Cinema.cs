﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library.Classes
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> listOfMovies)
        {
            Name = name;
            Halls = halls;
            ListOfMovies = listOfMovies;
        }
        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}"); 
        }
        public Cinema(string name)
        {
            Name = name;
        }
    }
}
