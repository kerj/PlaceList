using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _nameCity;
    private static List<Place> _location = new List<Place> {};
    private static List<Place> _crew = new List<Place> {};
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

    public static List<Place> Crew { get => _crew; set => _crew = value; }

    public int Id { get => _id; set => _id = value; }

    public static AddCrew(personFromCrew)
    {
      Crew.Add(Crew.CrewList[personFromCrew]);
    }

  }

  public class Crew
  {
    private string _person;
    private int _id;
    private static List<Place> _crewList = new List<Place> {};

    public Crew (string person)
    {
      _person = person;
      _id = _crew.Count;
      _crewList.Add(this);
    }
    public string _person { get => _person; set => _person = value; }

    public int Id { get => _id; set => _id = value; }

    public static List<Place> CrewList { get => _crewList; set => _crewList = value; }

  }

}
