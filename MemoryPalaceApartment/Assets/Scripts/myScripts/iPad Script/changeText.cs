using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;


public class changeText : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
     

    public Button openMenu;
    public Button xButton;
    public GameObject topLayer;
    public GameObject emotion;
    public GameObject symbol;
    public GameObject Tophat;
    public GameObject flag;
    public GameObject rainbow;
    public GameObject microscope;

    // Start is called before the first frame update
    void Start()
    {
        text1.gameObject.SetActive(true);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (xButton.gameObject.activeInHierarchy == true)
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(false);

            //text2.gameObject.SetActive(false);
            //text3.gameObject.SetActive(true);
        }
        //else if (topLayer.gameObject.activeInHierarchy == false && text2.gameObject.activeInHierarchy ==true)
        else if(emotion.activeInHierarchy==true)//|| symbol.activeInHierarchy == true || Tophat.activeInHierarchy == true || flag.activeInHierarchy == true || rainbow.activeInHierarchy == true || microscope.activeInHierarchy == true)
        {
            Debug.Log("something is true");
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);
            text4.gameObject.SetActive(false);

        }
        else
        {
            text1.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(false);
        }
    }

    //public void TextChange()
    //{
    //    changeText.text = 
    //}
}
