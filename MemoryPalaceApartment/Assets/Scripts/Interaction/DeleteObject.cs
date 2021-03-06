﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Deletes a game object when it hits the collider of a gameobject this script is attached to.
public class DeleteObject : MonoBehaviour
{
    public GameObject menu1 = null;
    private Menu menuScript1 = null;

    void Awake()
    {
        menuScript1 = menu1.GetComponent<Menu>();
        Debug.Log("The menu is: " + menu1 + " and the script is: " + menuScript1);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger ran");
        if(menuScript1.getState() == 0)
        {
            if(other.gameObject == null)
            {
                //return;
            }
            //only destroys objects with specific tags assigned to them
            else if (other.gameObject.CompareTag("object") || other.gameObject.CompareTag("coin") ||
            other.gameObject.CompareTag("smilingFace") || other.gameObject.CompareTag("topHat"))
            {
                //destroy it all!!!
                Destroy(other.gameObject);
                Debug.Log("Destroy ran");
            }
        }

    }
}
