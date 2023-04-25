using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings_button : MonoBehaviour
{
    public GameObject settings_menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnButtonPress()
    {
    settings_menu.SetActive(true);
    
    }
    
    void Update()
    {
        
    }
}
