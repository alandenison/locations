using System.Collections.Generic;

namespace Places
{
  public class Place
  {
    private string _location;
    private string _description;
    private string _image;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place(string location, string description, string image)
    {
      _location = location;
      _description = description;
      _image = image;
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
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetImage()
    {
      return _image;
    }
    public void SetImage(string newImage)
    {
      _image = newImage;
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
