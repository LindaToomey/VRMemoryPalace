using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuRotation : MonoBehaviour
{
    public GameObject menuButton;
    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        menuButton.transform.rotation = mainCamera.transform.rotation;
    }
}
