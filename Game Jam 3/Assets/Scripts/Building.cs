using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [Header("Buildings")]
    public GameObject wallBlueprint;
    public GameObject wall;

    public GameObject largeWallBlueprint;
    public GameObject largeWall;
    public GameObject slopeBlueprint;
    public GameObject slopeO;

    [Header("Teck")]
    public Transform spawnpoint;
    public Transform largeposition;
    public Transform slope;

    private bool readyBuildWall = false;

    private bool inv1 = false;
    private bool inv2 = false;
    private bool inv3 = false;
    private bool inv4 = false;
    private bool inv5 = false;
    private bool inv6 = false;
    private bool inv7 = false;
    private bool inv8 = false;
    private bool inv9 = false;


    private void Start()
    {
        wallBlueprint.SetActive(false);
        largeWallBlueprint.SetActive(false);
        slopeBlueprint.SetActive(false);

}

private void Update()
    {

        // new ver
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            inv1 = true;
            inv2 = false;
            inv3 = false;
            inv4 = false;
            inv5 = false;
            inv6 = false;
            inv7 = false;
            inv8 = false;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            inv1 = false;
            inv2 = true;
            inv3 = false;
            inv4 = false;
            inv5 = false;
            inv6 = false;
            inv7 = false;
            inv8 = false;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            inv1 = false;
            inv2 = false;
            inv3 = true;
            inv4 = false;
            inv5 = false;
            inv6 = false;
            inv7 = false;
            inv8 = false;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            inv1 = false;
            inv2 = false;
            inv3 = false;
            inv4 = true;
            inv5 = false;
            inv6 = false;
            inv7 = false;
            inv8 = false;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            inv1 = false;
            inv2 = false;
            inv3 = false;
            inv4 = false;
            inv5 = true;
            inv6 = false;
            inv7 = false;
            inv8 = false;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            inv1 = false;
            inv2 = false;
            inv3 = false;
            inv4 = false;
            inv5 = false;
            inv6 = true;
            inv7 = false;
            inv8 = false;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            inv1 = false;
            inv2 = false;
            inv3 = false;
            inv4 = false;
            inv5 = false;
            inv6 = false;
            inv7 = true;
            inv8 = false;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            inv1 = false;
            inv2 = false;
            inv3 = false;
            inv4 = false;
            inv5 = false;
            inv6 = false;
            inv7 = false;
            inv8 = true;
            inv9 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            inv1 = false;
            inv2 = false;
            inv3 = false;
            inv4 = false;
            inv5 = false;
            inv6 = false;
            inv7 = false;
            inv8 = false;
            inv9 = true;
        }

        if (inv1 == true)
        {

            wallBlueprint.SetActive(true);
            largeWallBlueprint.SetActive(false);
            slopeBlueprint.SetActive(false);

            if (Input.GetKeyDown(KeyCode.F))
            {
                Instantiate(wall, spawnpoint.position, spawnpoint.rotation);
                wall.SetActive(true);

            }

        }
        else if (inv2 == true)
        {
            wallBlueprint.SetActive(false);
            largeWallBlueprint.SetActive(true);
            slopeBlueprint.SetActive(false);

            if (Input.GetKeyDown(KeyCode.F))
            {
                Instantiate(largeWall, largeposition.position, largeposition.rotation);
                largeWall.SetActive(true);

            }
        }
        else if (inv3 == true)
        {
            wallBlueprint.SetActive(false);
            largeWallBlueprint.SetActive(false);
            slopeBlueprint.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F))
            {
                Instantiate(slopeO, slope.position, slope.rotation);
                largeWall.SetActive(true);

            }
        }
        else if (inv4 == true)
        {

        }
        else if (inv5 == true)
        {

        }
        else if (inv6 == true)
        {

        }
        else if (inv7 == true)
        {

        }
        else if (inv8 == true)
        {

        }
        else if (inv9 == true)
        {

        }

        //new ver


    }
}
        
       
    

