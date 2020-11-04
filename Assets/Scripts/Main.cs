using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS IS THE ONLY CLASS TO BE ALLOWED THE UPDATE() AND START() FUNCTION.
class Main : MonoBehaviour
{
    [SerializeField] CameraControlls cameraControlls;
    [SerializeField] UI ui;
    [SerializeField] PlayerManager playerManager;
    //THIS IS THE ONLY CLASS TO BE ALLOWED THE START() FUNCTION.
    void Start()
    {
        SolarSystemGenerator SolarSystemGenerator = this.GetComponent<SolarSystemGenerator>();
        IAstronomicalObject[] solarSystem = SolarSystemGenerator.generateSolarSystem(playerManager.players);

    }

    //a tick is the real-time game equivalent of a turn. 
    int tick;
    void newTick()
    {
        //Updates the UI every tick
        AstronomicalObject selectedAstronomicalObject = cameraControlls.selectedAstronomicalObject;
        /*if (selectedAstronomicalObject != null)
            uimanager.showPlanet(selectedAstronomicalObject, true);*/
        ui.displayDate();
        ui.date = ui.date.AddDays(1);
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