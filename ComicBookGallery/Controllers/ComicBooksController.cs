using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookLibraryManager.Models;
using ComicBookLibraryManager.Data;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{

		public ActionResult Detail()
		{
			using (var context = new Context())
			{
				var comicBooks = context.ComicBooks.ToList();
				var comicBookTitle = comicBooks.FirstOrDefault(c => c.Id == 1).Description;
				var comicBookIssueNumber = comicBooks.FirstOrDefault(c => c.Id == 1).IssueNumber;

				ViewBag.SeriesTitle = comicBookTitle;
				ViewBag.IssueNumber = comicBookIssueNumber;
				ViewBag.DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! " +
									"Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
				ViewBag.Artists = new string[]
				{
				"Script: Dan Slott",
				"Pencils: Humberto Ramos",
				"Inks: Victor Olazaba",
				"Colors: Edgar Delgado",
				"Letters: Chris Eliopoulos"
				};

				return View();
			}
		}

		public ActionResult Index()
		{

			ViewBag.SeriesTitle = "The Index";
			ViewBag.IssueNumber = 700;
			ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! " +
								"Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
			ViewBag.Artists = new string[]
			{
				"Script: Dan Slott",
				"Pencils: Humberto Ramos",
				"Inks: Victor Olazaba",
				"Colors: Edgar Delgado",
				"Letters: Chris Eliopoulos"
			};

			return View();

		}

	}
}