using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_control : MonoBehaviour
{
    public GameObject menu;
    public GameObject settings_menu;
    public bool paused = false;
    public bool settings = false;
    // Start is called before the first frame update
    void Start()
    {
        
        settings_menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if ((Input.GetKeyDown(KeyCode.O)) & (paused == true) & (settings == false)) {
            menu.SetActive(false);
            paused = false;
        }
        if ((Input.GetKeyDown(KeyCode.P)) & (paused == true) & (settings == false)) {

            settings_menu.SetActive(true);
            menu.SetActive(false);
            settings = true;
            
        }
        if ((Input.GetKeyDown(KeyCode.O)) & (paused == true) & (settings == true)) {
            settings_menu.SetActive(false);
            menu.SetActive(true);
            settings = false;
            
         }
        if ((Input.GetKeyDown(KeyCode.P)) & (paused == false) & (settings == false)) {

            menu.SetActive(true);
            paused = true;
            
        }
        
    }
}
