using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;

namespace _07_StreamingContentRepository_Console
{
    internal class ProgramUI
    {
        StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        public void Run()
        {
            _streamingRepo.SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            Console.WriteLine("Enter the number of the menu item that you would like to see\n" +
                "1. Create Movie\n" +
                "2. Remove Movie\n" +
                "3. See All Movies\n" +
                "");

            string userInput = (Console.ReadLine());
            int userInputParsed = int.Parse(userInput);

            switch (userInputParsed)
            {
                case 1:
                    AddNewMovie();
                    break;
                case 2:
                    RemoveMovie();
                    break;
                case 3:
                    SeeAllMovies();
                    break;
                default:
                    //
                    break;
            }
        }

        public void RemoveMovie()
        {
            SeeAllMovies();
            Console.WriteLine("Which movie would you like to remove? Please enter a title.");
            string movie = Console.ReadLine();

            _streamingRepo.RemoveStreamingContentFromList(movie);

            SeeAllMovies();
            Console.ReadKey();
        }

        public void SeeAllMovies()
        {
            List<StreamingContent> contentList = _streamingRepo.GetStreamingContentList();

            foreach (StreamingContent movie in contentList)
            {
                Console.WriteLine($"{movie.Title}, {movie.RunTime}, rated {movie.MovieRating}\n");
            }
        }

        private void AddNewMovie()
        {
            Console.WriteLine("What is the title of the movie?");
            string title = Console.ReadLine();

            Console.WriteLine("How would you rate the movie?");
            string starRating = Console.ReadLine();
            int starRatingParsed = int.Parse(starRating);

            Console.WriteLine("Runtime: ");
            string runTime = Console.ReadLine();
            float runTimeParsed = float.Parse(runTime);

            Console.WriteLine("Add a synopsis:");
            string summary = Console.ReadLine();

            Console.WriteLine("Is the movie family friendly? True of False.");
            string familyFriendlyString = Console.ReadLine();
            bool isFamilyFriendly = bool.Parse(familyFriendlyString);

            Console.WriteLine("What is the MPAA Rating? G, PG, PG-13, or R?");
            string movieRating = Console.ReadLine();

            Console.WriteLine("What is the genre of the movie?\n" +
                "1. Drama\n" +
                "2. Action\n" +
                "3. Horror\n" +
                "4. Comedy\n" +
                "5. Documentary\n" +
                "6. RomCom\n" +
                "7. Indie\n" +
                "8. SciFi");
            string genreAsString = Console.ReadLine();
            int genreInt = int.Parse(genreAsString);
            GenreType genre = (GenreType)genreInt;

            StreamingContent movie = new StreamingContent(title, starRatingParsed, runTimeParsed, summary, isFamilyFriendly, movieRating, genre);

            _streamingRepo.AddToList(movie);
        }
    }
}