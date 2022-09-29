using System;
using System.Collections.Generic;

namespace Organizer.Models
{
  public class Record
  {
    //Properties
    public string Title { get; set; }
		public string Genre { get; set; }
		public int Year { get; set; }
		//public List<string> TrackList { get; set; }
		public int Id { get; }
		private static List<Record> _discography = new List<Record> {};


   //Constructor
		public Record(string title, string genre, int year)
		{
			Title = title;
			Genre = genre;
			Year = year;
			// TrackList = trackList;
			_discography.Add(this);
			Id = _discography.Count;
		}

    //Methods
    public static List<Record> GetRecords()
    {
      return _discography;
    }

    public static void ClearAll()
    {
      _discography.Clear();
    }

    public static Record FindRecord(int id)
    {
      return _discography[id - 1];
    }

  }
}