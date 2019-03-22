using My_Library.Classes;
using My_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_app
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Movie
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            #endregion Movie

            #region Cinema
            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;
            #endregion Cinema

            Console.WriteLine($"Choose cinema: \n1. {cinema1.Name} \n2. {cinema2.Name}");
            Console.WriteLine("");
            string cinemaInput = Console.ReadLine();
            Console.WriteLine("----------------------");
            MovieMethod(MovieSet1, MovieSet2, cinemaInput, cinema1, cinema2);
            Console.ReadLine();
        }
        private static void WatchMovie(Cinema cinema)
        {
            try
            {
                Console.WriteLine("Choose a movie to watch: ( Write the name )");
                string inputMovie = Console.ReadLine();
                cinema.MoviePlaying(cinema.ListOfMovies.Where(movie => movie.Title.Trim().ToLower() == inputMovie.Trim().ToLower()).FirstOrDefault());
            }
            catch (Exception)
            {
                throw new Exception("There is no movie like that!");
            }
        }

        private static void MovieMethod(List<Movie> MovieSet1, List<Movie> MovieSet2, string cinemaInput, Cinema cinema, Cinema cinema1)
        {
            try
            {
                if (cinemaInput == "1")
                {
                    Console.WriteLine("Choose all movies or by genre: \n1. All movie \n2. Genre");
                    Console.WriteLine("");
                    string allMoviesOrGenreInput = Console.ReadLine();
                    Console.WriteLine("----------------------");
                    try
                    {
                        if (allMoviesOrGenreInput == "1")
                        {
                            foreach (var movie in MovieSet1)
                            {
                                Console.WriteLine(movie.Title);
                            }
                            Console.WriteLine("----------------------");
                            WatchMovie(cinema);   
                        }
                        else if (allMoviesOrGenreInput == "2")
                        {
                            Console.WriteLine("Choose genre: \n1. Comedy \n2. Horror \n3. Action \n4. Drama \n5. SciFi");
                            Console.WriteLine("");
                            string genre = Console.ReadLine();
                            Console.WriteLine("----------------------");
                            try
                            {
                                if (genre == "1")
                                {
                                    List<Movie> comedyMovies = MovieSet1.Where(m => m.Genre == Genre.Comedy).ToList();
                                    foreach (var movie in comedyMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "2")
                                {
                                    List<Movie> horrorMovies = MovieSet1.Where(m => m.Genre == Genre.Horror).ToList();
                                    foreach (var movie in horrorMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "3")
                                {
                                    List<Movie> actionMovies = MovieSet1.Where(m => m.Genre == Genre.Action).ToList();
                                    foreach (var movie in actionMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "4")
                                {
                                    List<Movie> dramaMovies = MovieSet1.Where(m => m.Genre == Genre.Drama).ToList();
                                    foreach (var movie in dramaMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "5")
                                {
                                    List<Movie> sciFiMovies = MovieSet1.Where(m => m.Genre == Genre.SciFi).ToList();
                                    foreach (var movie in sciFiMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else
                                {
                                    throw new Exception("You must choose form 1 to 5");
                                }
                                WatchMovie(cinema);
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message); ;
                            }
                        }
                        else
                        {
                            throw new Exception ("Choose 1 or 2");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (cinemaInput == "2")
                {
                    Console.WriteLine("Choose all movies or by genre: \n1. All movie \n2. Genre");
                    Console.WriteLine("");
                    string allMoviesOrGenreInput = Console.ReadLine();
                    Console.WriteLine("----------------------");
                    try
                    {
                        if (allMoviesOrGenreInput == "1")
                        {
                            foreach (var movie in MovieSet2)
                            {
                                Console.WriteLine(movie.Title);
                            }
                            Console.WriteLine("----------------------");
                            WatchMovie(cinema1);
                        }
                        else if (allMoviesOrGenreInput == "2")
                        {
                            Console.WriteLine("Choose genre: \n1. Comedy \n2. Horror \n3. Action \n4. Drama \n5. SciFi");
                            Console.WriteLine("");
                            string genre = Console.ReadLine();
                            Console.WriteLine("----------------------");
                            try
                            {
                                if (genre == "1")
                                {
                                    List<Movie> comedyMovies = MovieSet2.Where(m => m.Genre == Genre.Comedy).ToList();
                                    foreach (var movie in comedyMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "2")
                                {
                                    List<Movie> horrorMovies = MovieSet2.Where(m => m.Genre == Genre.Horror).ToList();
                                    foreach (var movie in horrorMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "3")
                                {
                                    List<Movie> actionMovies = MovieSet2.Where(m => m.Genre == Genre.Action).ToList();
                                    foreach (var movie in actionMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "4")
                                {
                                    List<Movie> dramaMovies = MovieSet2.Where(m => m.Genre == Genre.Drama).ToList();
                                    foreach (var movie in dramaMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else if (genre == "5")
                                {
                                    List<Movie> sciFiMovies = MovieSet2.Where(m => m.Genre == Genre.SciFi).ToList();
                                    foreach (var movie in sciFiMovies)
                                    {
                                        Console.WriteLine(movie.Title);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Choose form 1 to 5");
                                }
                                WatchMovie(cinema1);
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            throw new Exception ("Choose 1 or 2");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    throw new Exception ("Choose 1 or 2");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
