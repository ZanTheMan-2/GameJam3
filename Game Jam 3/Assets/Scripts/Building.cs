using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [Header("Buildings")]
    public GameObject blueprint;
    public GameObject wall;

    [Header("Teck")]
    public Transform spawnpoint;
    private bool readyBuildWall = false;

    private void Start()
    {
        blueprint.SetActive(false);
        wall.SetActive(false);
    }

    private void Update()
    {
       if(readyBuildWall == true)
        if (Input.GetKeyDown(KeyCode.F))
        {
                Instantiate(wall, spawnpoint.position, spawnpoint.rotation);
                wall.SetActive(true);

            }
        if (Input.GetKeyDown(KeyCode.E))
        {
            blueprint.SetActive(true);
            readyBuildWall = true;

}
if (Input.GetKeyDown(KeyCode.Q))
        {
            blueprint.SetActive(false);
            readyBuildWall = false;

        }
    }
    
}
