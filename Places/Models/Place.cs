using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
      public string City { get; set; }
      public string Food { get; set; }

      // public string Photo { get; set; }
      // Image newImage = Image.FromFile("img_submit.gif");
      public int Id { get; }
      private static List<Place> _listOfDestinations = new List<Place> {};
      
      public Place()
      {
        // City = city;
        // Food = food;
        // Photo = photo;
        // __listOfDestinations.Add(this);
        // Id = _listOfDestinations.Count;

      }

      // public static List<Place> GetAll()
      // {
      //   return _listOfDestinations;
      // }

      // public static void ClearAll()
      // {
      //   _listOfDestinations.Clear();
      // }

      // public static Place Find(int searchId)
      // {
      //   return _listOfDestinations[searchId - 1];
      // }
    }
}