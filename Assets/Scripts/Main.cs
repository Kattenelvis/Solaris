using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS IS THE ONLY CLASS TO BE ALLOWED THE UPDATE() FUNCTION.
class Main : MonoBehaviour
{
    IAstronomicalObject Earth = new AstronomicalObject();
    IAstronomicalObject Moon = new AstronomicalObject();
    Country Player = new Country(Country.controlledBy.HUMAN);
    Country Enemy = new Country(Country.controlledBy.AI);
    Country UnclaimedLand = new Country(Country.controlledBy.NOONE);
    [SerializeField]
    CameraControlls cameraControlls;
    Resource hydrocarbons = new Resource("hydrocarbons");
    void Start()
    {
        Earth.regions = new List<IRegion>();
        Earth.regions.Add(new Region("The West", Player));
        Earth.regions.Add(new Region("The East", Enemy));
        Moon.regions = new List<IRegion>();
        Moon.regions.Add(new Region("The Forward Side", UnclaimedLand));
        Moon.regions.Add(new Region("The Back Side", UnclaimedLand));
    }

    //a tick is the real-time game equivalent of a turn. 
    int tick;
    void newTick()
    {
        //Updates the UI every tick
        AstronomicalObject selectedAstronomicalObject = cameraControlls.selectedAstronomicalObject;
        if (selectedAstronomicalObject != null)
            GameObject.Find("Canvas").GetComponent<UIManager>().showPlanet(selectedAstronomicalObject, true);
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