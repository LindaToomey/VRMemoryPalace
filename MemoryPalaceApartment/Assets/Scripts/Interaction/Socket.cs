﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    private Moveable storedObject = null; //what gameobject is currently stored in the socket
    private FixedJoint joint = null; //the joint the socket is attached to


    public void Awake()
    {
        joint = GetComponent<FixedJoint>(); 
    }

    public void Attach(Moveable newObject)
    {
        if (storedObject) return; //if there is already an object stored in the socket, return
        //otherwise put the new game object into the socket by attaching it to the joint component and setting its position to the position of the socket
        storedObject = newObject;
        storedObject.transform.position = transform.position;
        storedObject.transform.rotation = Quaternion.identity;
        Rigidbody storedBody = storedObject.gameObject.GetComponent<Rigidbody>();
        joint.connectedBody = storedBody;
    }

    public void Detach()
    {
        if (!storedObject) return; //if the socket is empty, return
        joint.connectedBody = null; //otherwise remove the stored object from the joint
        storedObject = null;

    }

    public Moveable GetStoredObject()
    {
        return storedObject;
    }

}