using System.Collections.Generic;
public interface IAstronomicalObject
{
    string Name {get; set;}
    List<IRegion> regions { get; set; }
}