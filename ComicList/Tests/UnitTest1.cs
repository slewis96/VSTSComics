using NUnit.Framework;
using ComicList.Models;
using System;
using System.Globalization;

namespace Tests
{
    public class Tests
    {
        public ComicBook TestComic = new ComicBook(1, "The Walking Dead #180", "Image Comics", "6th", "June", "https://imagecomics.com/comics/releases/the-walking-dead-180", "https://imagecomics.com/uploads/releases/_main/TheWalkingDead_180-1.png");

        [Test]
        public void ComicBookIDCorrectForm()
        {
            Assert.NotNull(TestComic.ID);
            Assert.IsInstanceOf<int>(TestComic.ID);
        }

        [Test]
        public void ComicBookSeriesTitleCorrectForm()
        {
            Assert.NotNull(TestComic.SeriesTitle);
            StringAssert.Contains("#", TestComic.SeriesTitle);
            Assert.IsInstanceOf<string>(TestComic.SeriesTitle);
        }

        [Test]
        public void ComicBookPublisherCorrectForm()
        {
            Assert.NotNull(TestComic.Publisher);
            Assert.IsInstanceOf<string>(TestComic.Publisher);
        }

        [Test]
        public void ComicBookDayCorrectForm()
        {
            Assert.NotNull(TestComic.Day);
            Assert.LessOrEqual(Int32.Parse(TestComic.Day.Substring(0,TestComic.Day.Length-2)), 31);
            Assert.IsInstanceOf<string>(TestComic.Day);
        }

        [Test]
        public void ComicBookMonthCorrectForm()
        {
            Assert.NotNull(TestComic.Month);
            Assert.IsInstanceOf<string>(TestComic.Month);
            StringAssert.Contains(TestComic.Month, "January, February, March, April, May, June, July, August, September, October, November,December");
        }

        [Test]
        public void ComicBookImageCorrectForm()
        {
            Assert.NotNull(TestComic.Image);
            StringAssert.Contains("http", TestComic.Image);
            Assert.IsInstanceOf<string>(TestComic.Image);
        }

        [Test]
        public void ComicBookToStringCorrectForm()
        {
            Assert.NotNull(TestComic);
            Assert.IsInstanceOf<string>(TestComic.toString());
            StringAssert.Contains("#", TestComic.toString());
        }
    }
}