using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class xButtonScript : MonoBehaviour
{
    public GameObject menu; //the menu game object
    public GameObject topLevel;
    public GameObject xButton;
    public Button myButton;
    //public GameObject menuButton;
 
    private Menu menuScript; //the menu script
    private int ca;


    // Start is called before the first frame update
    void Start()
    {
        menuScript = menu.GetComponent<Menu>();
    }

    void OnMouseDown()
    {
        Debug.Log("You Clicked The X Button");
        ca = menuScript.getState();
        if (ca == 2)
        {
            Debug.Log("Ca = 2");
            menuScript.toggleMenu(topLevel);
            xButton.SetActive(false);
            myButton.gameObject.SetActive(true);
        }
        else
        {
            
            menuScript.toggleMenu(null);
            //menuButton.SetActive(true);
            Debug.Log("else");
            xButton.SetActive(false);
            myButton.gameObject.SetActive(true);
        }
        //Debug.Log("mouse is down");
    }
}
