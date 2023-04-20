using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class raycast : MonoBehaviour
{
    public int scarpAmount = 0;
    public int totalScrap = 0;
    public GameObject scrap;
    

    [Header("UI")]
    public TextMeshProUGUI scrapUI;
    public GameObject loud;
    public GameObject interact;


    void Update()
    {
        interact.SetActive(false);
        scrapUI.SetText("scrap: " + scarpAmount);

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.transform.tag == "scrap")   // picks up scrap
            {
                interact.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("e");

                    StartCoroutine(waiter());
                    loud.SetActive(true);
                    Debug.Log("destroy");


                }
            }
        }
           
           
        if (hit.transform.tag == "Drop")   //drop off scrap
        {
            Debug.Log("Hit");
            interact.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("e");

                StartCoroutine(waiterDrop());
                loud.SetActive(true);
            }

        }
    }


    IEnumerator waiterDrop()
    {
        yield return new WaitForSeconds(0.8f);
        totalScrap += scarpAmount;
        scarpAmount = 0;
        loud.SetActive(false);
        
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.8f);
        scrap.SetActive(false);
        scarpAmount += 1;
        loud.SetActive(false);
    }
}
