using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _nameCity;
    private static List<Place> _location = new List<Place> {};
    private int _daysStayed;
    private string _info;
    private int _id;

    public Place (string nameCity, int daysStayed, string info)
    {
      _nameCity = nameCity;
      _location.Add(this);
      _daysStayed = daysStayed;
      _info = info;
      _id = _location.Count;
    }

    public string NameCity { get => _nameCity; set => _nameCity = value; }

    public static List<Place> Location { get => _location; set => _location = value; }

    public int DaysStayed { get => _daysStayed; set => _daysStayed = value; }

    public string Info { get => _info; set => _info = value; }

    public int Id { get => _id; set => _id = value; }

    public static Place FindItNow(int searchId)
    {
      return _location[searchId -1];
    }

    public static void ClearAll()
    {
      _location.Clear();
    }

  }
}
