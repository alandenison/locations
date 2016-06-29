using System.Collections.Generic;

namespace Places
{
  public class Place
  {
    private string _location;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place(string location)
    {
      _location = location;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetLocation()
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
