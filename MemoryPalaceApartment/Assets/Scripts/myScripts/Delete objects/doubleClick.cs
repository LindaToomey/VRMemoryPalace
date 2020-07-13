using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleClick : MonoBehaviour
{
    private float firstClickTime, timebetweenClicks;
    private bool coroutineAllowed;
    private int clickCounter;
    RaycastHit hit;
    Ray ray;
    public GameObject player;
    //public GameObject toDelete;


    // Start is called before the first frame update
    void Start()
    {
        firstClickTime = 0f;
        timebetweenClicks = 0.2f;
        clickCounter = 0;
        coroutineAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            clickCounter += 1;

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
    }

    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;
        while (Time.time < firstClickTime + timebetweenClicks)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                
                    ray.direction = Input.mousePosition;
                    ray.origin = player.transform.position;
                    Debug.DrawRay(ray.origin, ray.direction, Color.green, 10);
                    //Debug.Log (ray.direction);
                

                if (clickCounter == 2)
                {

                    Destroy(this.gameObject);
                    Debug.Log("deleteScript called" +this.gameObject.name);
                   
                    //Destroy(hit.collider);
                    //toDelete.SetActive(false);
                    //Debug.Log("Deleting");
                    break;
                }
                }
                yield return new WaitForEndOfFrame();           
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawLine(contact.point, contact.point + contact.normal, Color.green, 2, false);
        }
    }
}
