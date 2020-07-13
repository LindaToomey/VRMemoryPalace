using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Reflection;
//using System.Diagnostics;

public class newButtonScript : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    public GameObject topLayer;
    public GameObject menu;
    public Button xButton;
    public Button myButton;
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
            menu.SetActive(true);
            topLayer.SetActive(true);
            xButton.gameObject.SetActive(true);
            //myButton.gameObject.SetActive(false);
            imgCircle.fillAmount = 0;
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
        //Debug.Log("GVROn");
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }


}
