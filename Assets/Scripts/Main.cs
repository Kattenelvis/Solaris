using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS IS THE ONLY CLASS TO BE ALLOWED THE UPDATE() AND START() FUNCTION.
class Main : MonoBehaviour
{
    IAstronomicalObject EarthData = new AstronomicalObject();
    IAstronomicalObject Moon = new AstronomicalObject();
    [SerializeField] GameObject planetEarth;
    Country Player = new Country(Country.controlledBy.HUMAN);
    Country Enemy = new Country(Country.controlledBy.AI);
    Country UnclaimedLand = new Country(Country.controlledBy.NOONE);
    [SerializeField]
    CameraControlls cameraControlls;
    Resource hydrocarbons = new Resource("hydrocarbons");
    Building refinery = new Building("Refinery");
    UIManager uimanager; 
    
    //THIS IS THE ONLY CLASS TO BE ALLOWED THE START() FUNCTION.
    void Start()
    {
        uimanager = GameObject.Find("Canvas").GetComponent<UIManager>();


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
        
        Moon.regions = new List<IRegion>{
            new Region("The Front Side", UnclaimedLand),
            new Region("The Back Side", UnclaimedLand)
        };

        
        //inGameEarthData = EarthData;
        //uimanager.displayPlanetData(Earth.regions);
    }

    //a tick is the real-time game equivalent of a turn. 
    int tick;
    void newTick()
    {
        //Updates the UI every tick
        AstronomicalObject selectedAstronomicalObject = cameraControlls.selectedAstronomicalObject;
        if (selectedAstronomicalObject != null)
            uimanager.showPlanet(selectedAstronomicalObject, true);
        
        uimanager.displayTime(tick);
        uimanager.date = uimanager.date.AddDays(1);
        tick++;
    }
    const int maxSpeed = 100;

    [Range(0, maxSpeed)]
    [SerializeField]
    public int gameSpeed;
    int i = 0;
    //THIS IS THE ONLY CLASS TO BE ALLOWED THE UPDATE() FUNCTION.
    void Update()
    {
        /*the increment (increased by one every frame) modulo the difference between
        maxSpeed and current speed. Modulo is also known as "clock arithmetic", look it up on google.
        As game speed gets higher and higher, it becomes a smaller and smaller clock
        until gameSpeed = maxSpeed and we get a tiny clock that's always at 0*/
        if (i % (maxSpeed - gameSpeed) == 0)
            newTick();

        //If not paused, incriment by one
        if (gameSpeed != 0)
        {
            i++;
        }

        //Controls
        cameraControlls.cameraControlls();
    }
}