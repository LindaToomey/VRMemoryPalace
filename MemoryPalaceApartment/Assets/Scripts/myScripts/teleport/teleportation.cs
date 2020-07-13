using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    public GameObject player;
    public GameObject door;
    private int b;

    public void TeleportPlayer()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
        b++;
        if (b == 1)
        {
            door.SetActive(false);
        }

    }
}
