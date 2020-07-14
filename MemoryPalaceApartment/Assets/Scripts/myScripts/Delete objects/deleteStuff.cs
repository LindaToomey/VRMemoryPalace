using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteStuff : MonoBehaviour
{
    // private float firstClickTime, timebetweenClicks;
    //private bool coroutineAllowed;
    //private int clickCounter;
    // Start is called before the first frame update

    [SerializeField]
    private string selectableTag = "special";

    [SerializeField] 
    private Material highlightMaterial;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                Debug.Log("Selectable Tag");


                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    Destroy(selectionRenderer);
                    //selectionRenderer.material = highlightMaterial;
                }
            }
        }
    }
}
