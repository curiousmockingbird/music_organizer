using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Organizer.Models;
using System;

namespace Organizer.Controllers
{
	public class ArtistsController : Controller
	{
		[HttpGet("/artists")]
		public ActionResult Index()
		{
			List<Artist> artistList = Artist.GetArtists();
			return View(artistList);
		}

		[HttpGet("/artists/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("/artists")]
		public ActionResult Create(string name)
		{
			Artist artist = new Artist(name);
			return RedirectToAction("Index");
		}

		[HttpGet("artists/{id}")]
		public ActionResult Show(int id)
		{
			Dictionary<string, object> model = new Dictionary<string, object>();
			Artist artist = Artist.FindArtist(id);
			List<Record> discography = artist.Records;
			model.Add("artist", artist);
			model.Add("discography", discography);
			return View(model);
		}
	}
}