using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SolarSystemGenerator : MonoBehaviour
{
    IAstronomicalObject EarthData = new AstronomicalObject();
    IAstronomicalObject Moon = new AstronomicalObject();
    [SerializeField] GameObject planetEarth;
    [SerializeField] GameObject earthsMoon;
    Resource hydrocarbons = new Resource("hydrocarbons");
    Building refinery = new Building("Refinery");

    public IAstronomicalObject[] generateSolarSystem(List<Player> players)
    {

        GameObject inGameEarth = Instantiate(planetEarth, new Vector3(46, 0, 15), Quaternion.identity);
        inGameEarth.AddComponent<AstronomicalObject>();
        IAstronomicalObject EarthData = inGameEarth.GetComponent<AstronomicalObject>();

        //Move this to a text file later for mod compatability (more regions mod e.t.c)
        EarthData.regions = new List<IRegion>{
            new Region("Europe", players[1]),
            new Region("China", players[2]),
            new Region("Russia", players[2]),
            new Region("USA", players[2]),
        };
        EarthData.Name = "Earth";

        GameObject inGameMoon = Instantiate(earthsMoon, new Vector3(90, 0, 25), Quaternion.identity);
        inGameMoon.AddComponent<AstronomicalObject>();
        IAstronomicalObject MoonData = inGameMoon.GetComponent<AstronomicalObject>();

        MoonData.regions = new List<IRegion>{
            new Region("The Front Side", players[0]),
            new Region("The Back Side", players[0])
        };

        //TODO: Obviously make the solar system creator better
        MoonData.regions[0].refineries = 0;
        MoonData.regions[1].refineries = 0;
        MoonData.regions[0].fuel = 0;
        MoonData.regions[1].fuel = 0;
        MoonData.Name = "Moon";


        IAstronomicalObject[] output = { EarthData, Moon };

        return output;
    }
}
