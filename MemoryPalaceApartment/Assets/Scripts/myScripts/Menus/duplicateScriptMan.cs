using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class duplicateScriptMan : MonoBehaviour
{
    public GameObject prefab;
    public GameObject CopyPrefab;
    private GameObject cloned;
    private float z;
    private float x;
    private float y;
    private int a;
    public GameObject door;

    void OnMouseDown()
    {
        cloned = Instantiate(CopyPrefab);
        //cloned.AddComponent<Moveable>();
        //cloned.getComponent(duplicateScript).setActive(false);
        //cloned.GetComponent<duplicateScript>().enabled = false;

        cloned.transform.position = prefab.transform.position;
        cloned.transform.rotation = prefab.transform.rotation;
        cloned.transform.localScale = (prefab.transform.localScale) * 0.05f;
        z = cloned.transform.position.z;
        x = cloned.transform.position.x;
        y = cloned.transform.position.y;
        z += 0.1f;
        cloned.transform.position = new Vector3(x, y, z);
        a++;
        //cloned.transform.localScale = prefab.transform.localScale;

    }
    
}
