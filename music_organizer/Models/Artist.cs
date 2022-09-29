using System.Collections.Generic;

namespace Organizer.Models
{
  public class Artist
  {
    //Prop
    public string Name { get; set; }
    public int Id { get; }
    public List<Record> Records { get; set; }
    private static List<Artist> _artist = new List<Artist> {};

    //Const
    public Artist(string name)
    {
      Name = name;
      _artist.Add(this);
      Id = _artist.Count;
      Records = new List<Record>{};
    }
    
    //Method
		public static List<Artist> GetArtists()
		{
			return _artist;
		}

		public static Artist FindArtist(int id)
    {
      return _artist[id - 1];
    }

		public void AddRecord(Record record)
		{
			Records.Add(record);
		}
  }
}