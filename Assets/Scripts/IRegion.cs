using System.Collections.Generic;
public interface IRegion {
    Country owner {get; set;}
    int hydrocarbons{get; set;}
    int refineries{get; set;}
    int fuel{get; set;}
    string name{get; set;}
    //Please include a constructor aswell thanks
    //Region(string _name, Country _owner) {}
}