using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuClick : MonoBehaviour
{
    
    public GameObject topLayer;
    public Button myButton;
    public Button xButton;


    
    // Update is called once per frame
    void onMouseDown()
    {
        Debug.Log("Mouse Down");
        topLayer.SetActive(true);
        xButton.gameObject.SetActive(true);
        myButton.gameObject.SetActive(false);
    }
}
