using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class longClick : MonoBehaviour
{
    private float startTime, endTime;
    public GameObject toDelete;
    // Start is called before the first frame update
    void Start()
    {
        startTime = 0f;
        endTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            startTime = Time.time;

        if(Input.GetMouseButtonUp(0))
            endTime = Time.time;

        if (endTime - startTime > 1f)
        {
            Destroy(toDelete);
        }
    }
}
