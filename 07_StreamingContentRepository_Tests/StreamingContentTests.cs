using System;
using System.Collections.Generic;
using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_StreamingContentRepository_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void CreateStreamingContentObject()
        {
            //AAA Pattern --------------------------------------
            

            //Arrange
            StreamingContent contentOne = new StreamingContent();

            //Act
            contentOne.Title = "I Love You Man.";
            string expectedOne = "I Love You Man.";

            //Assert
            Assert.AreEqual(expectedOne, contentOne.Title);


            //Arrange Act
            StreamingContent contentTwo = new StreamingContent("I Love You Man.", 5, 2.20f, "Two guys hang out.", true, "R", GenreType.Comedy);

            string expectedTwo = "I Love You Man.";
            GenreType expectedGenre = GenreType.Comedy; // NOTE HOW ENUMS ARE DECLARED AND CALLED

            //Assert
            Assert.AreEqual(expectedTwo, contentTwo.Title);
            Assert.AreEqual(expectedGenre, contentTwo.Genre);
        }

        [TestMethod]
        public void AddToList_AddStreamingContentObject_ListCountShouldBeCorrectInt()
        {
            //Arrange
            StreamingContentRepository streamingRepo = new StreamingContentRepository();
            List<StreamingContent> contents = streamingRepo.GetStreamingContentList();

            StreamingContent contentThree = new StreamingContent("Jaws", 10, 2.12f, "A big shark.", true, "R", GenreType.Action);
            StreamingContent contentFour = new StreamingContent("Star Wars", 10, 1.46f, "A long time ago...", true, "PG-13", GenreType.SciFi);

            //Act
            int expected = 2;

            streamingRepo.AddToList(contentThree);
            streamingRepo.AddToList(contentFour);

            int actual = contents.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveStreamingContentFromListMethod_RemoveStreamingContentObjectFromList_ListCountShouldBeCorrectInt()
        {
            //Arrange
            StreamingContentRepository streamingRepo = new StreamingContentRepository();
            List<StreamingContent> contents = streamingRepo.GetStreamingContentList();

            StreamingContent contentThree = new StreamingContent("Jaws", 10, 2.12f, "A big shark.", true, "R", GenreType.Action);
            StreamingContent contentFour = new StreamingContent("Star Wars", 10, 1.46f, "A long time ago...", true, "PG-13", GenreType.SciFi);

            //Act
            int expected = 1;

            streamingRepo.AddToList(contentThree);
            streamingRepo.AddToList(contentFour);

            streamingRepo.RemoveStreamingContentFromList("Jaws");

            int actual = contents.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EditPropertyOfAMovie_CheckEditFromMethodIsCorrect()
        {
            //Arrange
            StreamingContentRepository streamingRepo = new StreamingContentRepository();
            List<StreamingContent> contents = streamingRepo.GetStreamingContentList();

            StreamingContent contentThree = new StreamingContent("Jaws", 10, 2.12f, "A big shark.", true, "R", GenreType.Action);
            StreamingContent contentFour = new StreamingContent("Star Wars", 10, 1.46f, "A long time ago...", true, "PG-13", GenreType.SciFi);

            //Act
            streamingRepo.AddToList(contentThree);
            streamingRepo.AddToList(contentFour);
            
        }

        [TestMethod]
        public void PrintMovieInfoToConsoleTest()
        {
            //Arrange
            StreamingContentRepository streamingRepo = new StreamingContentRepository();
            List<StreamingContent> contents = streamingRepo.GetStreamingContentList();

            StreamingContent contentThree = new StreamingContent("Jaws", 10, 2.12f, "A big shark.", true, "R", GenreType.Action);
            StreamingContent contentFour = new StreamingContent("Star Wars", 10, 1.46f, "A long time ago...", true, "PG-13", GenreType.SciFi);

            //Act
            streamingRepo.AddToList(contentThree);
            streamingRepo.AddToList(contentFour);

            PrintMovieInfoToConsoleTest();
        }
    }
}
