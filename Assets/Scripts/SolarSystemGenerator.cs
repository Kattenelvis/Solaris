using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SolarSystemGenerator : MonoBehaviour{
    IAstronomicalObject EarthData = new AstronomicalObject();
    IAstronomicalObject Moon = new AstronomicalObject();
    [SerializeField] GameObject planetEarth;
    [SerializeField] GameObject earthsMoon;
    Country Player = new Country(Country.controlledBy.HUMAN);
    Country Enemy = new Country(Country.controlledBy.AI);
    Country UnclaimedLand = new Country(Country.controlledBy.NOONE);
    Resource hydrocarbons = new Resource("hydrocarbons");
    Building refinery = new Building("Refinery");

    public IAstronomicalObject[] generateSolarSystem()
    {

        GameObject inGameEarth = Instantiate(planetEarth, new Vector3(46,0,15), Quaternion.identity);
        inGameEarth.AddComponent<AstronomicalObject>();
        IAstronomicalObject EarthData = inGameEarth.GetComponent<AstronomicalObject>();

        //Move this to a text file later for mod compatability (more regions mod e.t.c)
        EarthData.regions = new List<IRegion>{
            new Region("Europe", Player),
            new Region("China", Enemy),
            new Region("Russia", Enemy),
            new Region("USA", Enemy),
        };
        EarthData.Name = "Earth";
        
        GameObject inGameMoon = Instantiate(earthsMoon, new Vector3(90,0,25), Quaternion.identity);
        inGameMoon.AddComponent<AstronomicalObject>();
        IAstronomicalObject MoonData = inGameMoon.GetComponent<AstronomicalObject>();

        MoonData.regions = new List<IRegion>{
            new Region("The Front Side", UnclaimedLand),
            new Region("The Back Side", UnclaimedLand)
        };
        MoonData.Name = "Moon";


        IAstronomicalObject[] output = {EarthData, Moon};

        return output;
    } 
}
