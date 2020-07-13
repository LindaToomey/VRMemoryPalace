using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUpMenu : MonoBehaviour
{
    public GameObject menu; //the menu game object
    private Menu menuScript; //the menu script

    // Start is called before the first frame update
    void Start()
    {
        //initialize menu objects
        menuScript = menu.GetComponent<Menu>();
    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        menuScript.toggleMenu(null);
        //Debug.Log("mouse is down");
    }
}
