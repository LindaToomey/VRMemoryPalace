using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideIpad : MonoBehaviour
{
    public GameObject doorway;
    public GameObject doorway1;
    public GameObject doorway2;
    public Button ipad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per 
    void Update()
    {
        if(doorway1.activeInHierarchy == false && doorway.activeInHierarchy == false&& doorway2.activeInHierarchy == false)
        {
            ipad.gameObject.SetActive(false);
        }
    }
}
