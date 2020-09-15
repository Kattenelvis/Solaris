using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles game logic. Make sure to keep logic seperated from graphics.
public class Main : MonoBehaviour
{

    [Range(0, 100)]
    public const int maxSpeed = 100;

    [Range(0, maxSpeed)]
    public int gameSpeed;

    //a tick is the real-time equivalent of a turn. 
    public int tick;
    void newTick()
    {
        tick++;
    }

    private int i = 0;
    private void Update()
    {
        //the increment (increased by one every frame) modulo the difference between
        //maxSpeed and current speed. As game speed gets higher and higher, it becomes
        //a smaller and smaller clock until gameSpeed = maxSpeed and we get a tiny clock that's always at 0
        if (i % (maxSpeed - gameSpeed) == 0)
            newTick();

        //If not paused, incriment by one
        if (gameSpeed != 0)
        {
            i++;
        }
    }
}