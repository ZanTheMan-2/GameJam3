using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmyAi : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    float m_Speed;

    public Transform target;

    public bool isAtacking = false;

    private Animation anim;
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
        anim["Rikayon"].layer = 123;
    }


    void Update()
    {
        if(isAtacking == false)
        {
            if (target != null)
            {
                transform.LookAt(target);
            }

            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;
        }
        if(isAtacking == true)
        {
            // somethings
        }
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obsticle")
        {
            isAtacking = true;
        }
        else isAtacking = false;


        }
}
