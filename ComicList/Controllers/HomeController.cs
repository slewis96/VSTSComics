﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicList.Models;

namespace ComicList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Comicbooks
            List<ComicBook> allComics = new List<ComicBook>();


            allComics.Add(new ComicBook(1, "The Walking Dead #180", "Image Comics", "6th", "June", "https://imagecomics.com/comics/releases/the-walking-dead-180", "https://imagecomics.com/uploads/releases/_main/TheWalkingDead_180-1.png"));
            allComics.Add(new ComicBook(2, "I Hate Fairyland #19", "Image Comics", "13th", "June", "https://imagecomics.com/comics/releases/i-hate-fairyland-19", "https://imagecomics.com/uploads/releases/_main/IHateFairyland_19-1.png"));
            allComics.Add(new ComicBook(3, "The Walking Dead #181", "Image Comics", "4th", "July", "https://imagecomics.com/comics/releases/the-walking-dead-181", "https://imagecomics.com/uploads/releases/_main/TheWalkingDead_181-1.png"));
            allComics.Add(new ComicBook(4, "I Hate Fairyland #20", "Image Comics", "4th", "July", "https://imagecomics.com/comics/releases/i-hate-fairyland-20", "https://imagecomics.com/uploads/releases/_main/IHateFairyland_20-1.png"));
            allComics.Add(new ComicBook(5, "Hellblazer #23", "DC Comics", "27th", "June", "https://www.dccomics.com/comics/the-hellblazer-2016/the-hellblazer-23", "https://www.dccomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/08/HLB_23_300-001_HD_5b84811accaef9.33131335.jpg?itok=0G6sX3Mi"));
            allComics.Add(new ComicBook(6, "Hellblazer #24", "DC Comics", "25th", "July", "https://www.dccomics.com/comics/the-hellblazer-2016/the-hellblazer-24", "https://www.dccomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/08/HLB_24_300-001_HD_5b8481388cb399.89510756.jpg?itok=Q0cDUxvE"));
            allComics.Add(new ComicBook(7, "The Walking Dead #182", "Image Comics", "1st", "August", "https://imagecomics.com/comics/releases/the-walking-dead-182", "https://imagecomics.com/uploads/releases/_main/TheWalkingDead_182-1.png"));
            allComics.Add(new ComicBook(8, "The Walking Dead #183", "Image Comics", "5th", "September", "https://imagecomics.com/comics/releases/the-walking-dead-183", "https://imagecomics.com/uploads/releases/_main/TWD183_Cover.jpg"));
            allComics.Add(new ComicBook(9, "The Walking Dead #184", "Image Comics", "3rd", "October", "https://imagecomics.com/comics/releases/the-walking-dead-184", "https://imagecomics.com/uploads/releases/_main/TWD184_Cover.jpg"));
            allComics.Add(new ComicBook(10, "The Sandman Universe #1", "Vertigo Comics", "8th", "August", "https://www.vertigocomics.com/comics/the-sandman-universe-2018/the-sandman-universe-1", "https://www.vertigocomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/08/SNDUNI_01_300-001_HD_5b8739a8e82e52.51406293.jpg?itok=dCKNBiFH"));
            allComics.Add(new ComicBook(11, "The Dreaming #1", "Vertigo Comics", "5th", "September", "https://www.vertigocomics.com/comics/the-dreaming-2018/the-dreaming-1", "https://www.vertigocomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/08/DREAMNG_01_300-001_HD_5b7f52c1460849.73001363.jpg?itok=LwAT-jVP"));
            allComics.Add(new ComicBook(12, "House of Whispers #1", "Vertigo Comics", "12th", "September", "https://www.vertigocomics.com/comics/house-of-whispers-2018/house-of-whispers-1", "https://www.vertigocomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/08/HOWSP_01_300-001_HD_5b857ce4808756.75303050.jpg?itok=x35ILwYh"));
            allComics.Add(new ComicBook(13, "The Dreaming #2", "Vertigo Comics", "3rd", "October", "https://www.vertigocomics.com/comics/the-dreaming-2018/the-dreaming-2", "https://www.vertigocomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/09/DREAMING_02_300-001_HD_5ba1386966b4f6.00648336.jpg?itok=bpE-u6FS"));
            allComics.Add(new ComicBook(14, "House of Whispers #2", "Vertigo Comics", "10th", "October", "https://www.vertigocomics.com/comics/house-of-whispers-2018/house-of-whispers-2", "https://www.vertigocomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/09/HOWSP_02_300-001_HD_5baa7cd23022b8.23218505.jpg?itok=hHnQwrbg"));
            allComics.Add(new ComicBook(15, "Lucifer #1", "Vertigo Comics", "17th", "October", "https://www.vertigocomics.com/comics/lucifer-2018/lucifer-1", "https://www.vertigocomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/10/LUCI_01_300-001_HD_5bb3b345a4b2c2.64568755.jpg?itok=qhcVNaKu"));
            allComics.Add(new ComicBook(16, "The Books of Magic #1", "Vertigo Comics", "24th", "October", "https://www.vertigocomics.com/comics/the-books-of-magic-2018/the-books-of-magic-1", "https://www.vertigocomics.com/sites/default/files/styles/covers192x291/public/comic-covers/2018/10/BOMG_01_300-001_HD_5bb7fa451d1fc8.01303130.jpg?itok=S6PBlZQG"));
            string[] months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            //Comics given to index
            ViewBag.Comics = new List<List<ComicBook>>();

            //For each month match comics and add list to Viewbag list
            foreach (string month in months)
            {
                List<ComicBook> comicMonth = new List<ComicBook>();
                foreach (ComicBook comic in allComics)
                {
                    if (comic.Month == month)
                    {
                        comicMonth.Add(comic);
                    }
                }
                if (comicMonth.Any())
                {
                    ViewBag.Comics.Add(comicMonth);
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
