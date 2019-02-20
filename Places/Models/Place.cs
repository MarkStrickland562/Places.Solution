using System.Collections.Generic;
namespace Places.Models
{
  public class Place
  {
    private string _myCityName;
    private static List<Place> _instances = new List<Place> {};
    private string _myPhoto;
    private string _myDuration;
    private string _myCompanion;
    private string _myJournalEntry;

    // Constructor for creating an instance of the Place class.

    public Place (string myCityName, string myPhoto, string myDuration, string myCompanion, string myJournalEntry)
    {
      _myCityName = myCityName;
      _instances.Add(this);
      _myPhoto = myPhoto;
      _myDuration = myDuration;
      _myCompanion = myCompanion;
      _myJournalEntry = myJournalEntry;
    }

    // Getter method for the Place class.

    public string GetCityName(){ return _myCityName;}
    public string GetPhoto(){ return _myPhoto;}
    public string GetDuration(){ return _myDuration;}
    public string GetCompanion(){ return _myCompanion;}
    public string GetJournalEntry(){ return _myJournalEntry;}


    // Setter method for the Place class.

    public void SetCityName(string newCityName){ _myCityName = newCityName;}
    public void SetPhoto(string newPhoto){ _myPhoto = newPhoto;}
    public void SetDuration(string newDuration){ _myDuration = newDuration;}
    public void SetCompanion(string newCompanion){ _myCompanion = newCompanion;}
    public void SetJournalEntry(string newJournalEntry){ _myJournalEntry = newJournalEntry;}

    public static List<Place> GetAll()
    {
      return _instances;
    }

  }
}
