using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Reflection;

public class newXbutton : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    public GameObject topLayer;
    public GameObject menu;
    public Button myButton;
    public Button xButton;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
            //Debug.Log("Fill amount");
        }

        if (gvrTimer > totalTime)
        {
            //topLayer.SetActive(false);
            menu.SetActive(false);
            xButton.gameObject.SetActive(false);
            myButton.gameObject.SetActive(true);
            imgCircle.fillAmount = 0;
            //gvrTimer = 0;
            
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
        Debug.Log("GVROn");
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }


}
