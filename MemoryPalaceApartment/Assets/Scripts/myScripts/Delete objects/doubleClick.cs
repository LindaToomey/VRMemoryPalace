using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleClick : MonoBehaviour
{
    private float firstClickTime, timebetweenClicks;
    private bool coroutineAllowed;
    private int clickCounter;
    //RaycastHit hit;
    //Ray ray;
    [SerializeField]
    private string selectableTag = "special";
    //public GameObject player;
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
       // ray.direction = Input.mousePosition;
       // ray.origin = new Vector3(-11f, 1.69f, 0f);
       // Debug.DrawRay(ray.origin, ray.direction, Color.green, 10);
        coroutineAllowed = false;
        while (Time.time < firstClickTime + timebetweenClicks)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Raycast Hit");
                //if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                //Debug.Log(string.Equals(this.gameObject.name, "Copy Menu_sadEmoji Variant 1(Clone)2") + this.gameObject.name+ " Copy Menu_sadEmoji Variant 1(Clone)2");
                //if(string.Equals(this.gameObject.name, "Copy Menu_sadEmoji Variant 1(Clone)2"))
                //{
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    Debug.Log("tag");
                    var selectionRenderer = selection.GetComponent<Renderer>();
                    // ray.direction = Input.mousePosition;
                    // ray.origin = new Vector3(-11f, 1.69f, 0f);
                    // Debug.DrawRay(ray.origin, ray.direction, Color.green, 10);
                    //Debug.Log (ray.direction);
                    if (selectionRenderer != null)
                    {
                        Debug.Log("selectionrenderer!null");
                        if (clickCounter == 2)
                        {
                            Debug.Log("deleteScript called" + this.gameObject.name);
                            Destroy(this.gameObject);
                            //Destroy(selectionRenderer);
                            break;
                        }
                    }
                }
            }
        
            
                    yield return new WaitForEndOfFrame();           
                }       
            clickCounter = 0;
            firstClickTime = 0f;
            coroutineAllowed = true;
    }

    
}
