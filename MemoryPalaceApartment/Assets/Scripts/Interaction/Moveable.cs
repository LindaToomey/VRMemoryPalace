using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : Interactable
{
    private Vector3 mOffset;
    private float mZCoord;
    
    //private Socket activeSocket = null; //the socket the gameobject is attached to (if any)

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        //pixel coordinates of mouse(x,y)
        Vector3 mousePoint = Input.mousePosition;
        //z coordinate of game object on screen
        mousePoint.z = mZCoord;
        //Convert to world points
        return
            Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }
    //public override void StartInteraction(Hand2 hand)
    //{
    //   hand.PickUp(this);
    //}

    //public override void Interaction(Hand2 hand)
    //{
    //    GetComponent<ColorToggle>().ToggleColor();
    //}

    //public override void EndInteraction(Hand2 hand)
    // {
    //    hand.Drop();
    //}

    //changes the socket the object is attached to



    //public void AttachNewSocket(Socket newSocket)
    //{
    //   if (newSocket.GetStoredObject()) //if there is already an object in the socket, do nothing
    //    {
     //       return;
    //    }
    //    ReleaseOldSocket(); //otherwise release the gameobject from it's previous socket
    //    activeSocket = newSocket;
    //    activeSocket.Attach(this); //attaches the game object to the specified new socket
    //    isAvailable = false;
    //}

    //public void ReleaseOldSocket()
    //{
    //    if (!activeSocket) //if there is no previous active socket, do nothing
    //    {
    //        return;
    //    }
    //    activeSocket.Detach(); //remove the object from the socket
    //    activeSocket = null;
    //    isAvailable = true; //says the object is available to attach to a new socket
    //}
}
