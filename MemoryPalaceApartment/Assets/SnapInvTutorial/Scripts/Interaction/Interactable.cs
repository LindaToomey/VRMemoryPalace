﻿using UnityEngine;


public class Interactable : MonoBehaviour
{
    protected bool isAvailable = true;

    public virtual void StartInteraction(Hand2 hand)
    {
        print("start");
    }

    public virtual void Interaction(Hand2 hand)
    {
        print("interaction");
    }

    public virtual void EndInteraction(Hand2 hand)
    {
        print("end");
    }

    public bool GetAvailability()
    {
        return isAvailable;
    }
}
