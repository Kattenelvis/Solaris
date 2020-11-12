using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
public class SolarSystemGenerator : MonoBehaviour
{
    IAstronomicalObject EarthData = new AstronomicalObject();
    IAstronomicalObject MoonData = new AstronomicalObject();
    IAstronomicalObject SunData = new AstronomicalObject();
    [SerializeField] GameObject planetEarth;
    [SerializeField] GameObject earthsMoon;
    [SerializeField] GameObject Sun;
    Resource hydrocarbons = new Resource("hydrocarbons");
    Building refinery = new Building("Refinery");
    [SerializeField] Vector3 earthPosition;
    [SerializeField] Vector3 moonPosition;
    [SerializeField] Vector3 sunPosition;

    public IAstronomicalObject[] generateSolarSystem()
    {

        GameObject inGameEarth = Instantiate(planetEarth, earthPosition, Quaternion.identity);
        inGameEarth.AddComponent<AstronomicalObject>();
        IAstronomicalObject EarthData = inGameEarth.GetComponent<AstronomicalObject>();

        //Move this to a text file later for mod compatability (more regions mod e.t.c)
        EarthData.regions = new List<IRegion>{
            new Region("Europe"),
            new Region("China"),
            new Region("Russia"),
            new Region("USA"),
        };
        EarthData.Name = "Earth";



        GameObject inGameMoon = Instantiate(earthsMoon, moonPosition, Quaternion.identity);
        inGameMoon.AddComponent<AstronomicalObject>();
        IAstronomicalObject MoonData = inGameMoon.GetComponent<AstronomicalObject>();

        MoonData.regions = new List<IRegion>{
            new Region("The Front Side"),
            new Region("The Back Side")
        };

        //TODO: Obviously make the solar system creator better
        MoonData.regions[0].refineries = 0;
        MoonData.regions[1].refineries = 0;
        MoonData.regions[0].fuel = 0;
        MoonData.regions[1].fuel = 0;
        MoonData.Name = "Moon";

        GameObject inGameSun = Instantiate(Sun, sunPosition, Quaternion.identity);
        inGameSun.AddComponent<AstronomicalObject>();
        IAstronomicalObject SunData = inGameSun.GetComponent<AstronomicalObject>();

        SunData.Name = "Sun";

        IAstronomicalObject[] output = { EarthData, MoonData, SunData };

        List<Region> lol = getSolarSystemEditorData(EarthData);
        return output;
    }

    public static List<Region> getSolarSystemEditorData(IAstronomicalObject astroObject)
    {
        /*string path = Application.dataPath + "/Scripts/SolarSystemEditor.txt";
        var file = File.ReadAllLines(path);
        print(file[4].Split(',')[0].Remove(' '));*/
        return new List<Region>();
    }
}
