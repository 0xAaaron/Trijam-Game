using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPlacement : MonoBehaviour
{
    //Variables To Move the portals
    private Vector2 mousepos;
    private Transform bluePortal; 

    public Transform orangePortal;
    public float timebtwteleport; 

    public float rangeX;
    public float rangeY;

    void Start()
    {
        //Finding the blue portal
        bluePortal = GameObject.FindGameObjectWithTag("BluePortal").GetComponent<Transform>();

        //Starts the teleporting
        InvokeRepeating("TeleportObj", 2, timebtwteleport);
    }

    void Update()
    {
        //Teleports Blue Portal to the area where the mouse was clicked
        if(Input.GetMouseButtonDown(0))
        {
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            bluePortal.position = new Vector2(mousepos.x, mousepos.y);
        }
    }

    public void TeleportObj()
    {
        //Finds location within the camera range and teleports portal to there
        float x = Random.Range(-rangeX, rangeX);
        float y = Random.Range(-rangeY, rangeY);
        orangePortal.position = new Vector2(x, y);
    }
}
