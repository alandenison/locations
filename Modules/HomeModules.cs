using Nancy;
using Places;
using System.Collections.Generic;


namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["Places_Form.cshtml"];
      };
      Get["/places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["Places_List.cshtml", allPlaces];
      };
      Post["/Places"] = _ => {
        Place newPlace = new Place(Request.Form["new-place"], Request.Form["new-desc"], Request.Form["new-image"]);
        List<Place> allPlaces = Place.GetAll();
        return View["Places_List.cshtml", allPlaces];
      };
      Get["/places/{id}"] = parameters => {
        Place place = Place.Find(parameters.id);
        return View["place.cshtml", place];
      };
    }
  }
}
