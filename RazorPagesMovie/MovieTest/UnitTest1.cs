using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using System;

namespace MovieTest
{
    [TestClass]
    public class UnitTest1
    {
        RazorPagesMovieContext context;
        Movie testmovie;
        DateTime testdate;

        [TestMethod]
        public void TestMethod1()
        {
            testdate = new DateTime(2023, 2, 3);
            testmovie = new Movie()
            {
                Title = "CarpleTunnel the Movie",
                ReleaseDate = testdate,
                Genre = "Action",
                Price = 18
            };
            context.Add(testmovie);
            context.SaveChanges();

            Assert.IsTrue(testmovie.Title == "CarpleTunnel the Movie");
        }
    }
}