using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        List<StreamingContent> _streamingContentList = new List<StreamingContent>();

        public void AddToList(StreamingContent content)
        {
            _streamingContentList.Add(content);
        }

        public List<StreamingContent> GetStreamingContentList()
        {
            return _streamingContentList;
        }

        public void RemoveStreamingContentFromList(string title)
        {
            foreach (StreamingContent movie in _streamingContentList)
            {
                if (movie.Title == title)
                {
                    _streamingContentList.Remove(movie);
                    break;
                }
            }
        }
        
        public void EditContent()
        {
            
        }

        public void SeedList()
        {
            StreamingContent movieOne = new StreamingContent("Star Wars", 11, 1.50f, "A long time ago...", true, "PG", GenreType.SciFi);
            StreamingContent movieTwo = new StreamingContent("Jaws", 9, 1.50f, "Sharks eat people.", true, "PG-13", GenreType.Horror);
            StreamingContent movieThree = new StreamingContent("It", 3, 1.50f, "Creepy clown monster.", true, "PG", GenreType.Horror);
            StreamingContent movieFour = new StreamingContent("Dumb and Dumber", 12, 1.50f, "Totally redeem yourself.", true, "PG-13", GenreType.Comedy);

            AddToList(movieOne);
            AddToList(movieTwo);
            AddToList(movieThree);
            AddToList(movieFour);
        }
    }
}
