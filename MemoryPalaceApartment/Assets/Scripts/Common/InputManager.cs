﻿using UnityEngine;
using UnityEngine.Events;
using Valve.VR;

//This is used with steamVR to assign player actions when buttons are pressed on the controller.
public class InputManager : MonoBehaviour
{

    [Header("Trigger")]
    public SteamVR_Action_Boolean TriggerAction = null;
    public UnityEvent OnTriggerDown = new UnityEvent();
    public UnityEvent OnTriggerUp = new UnityEvent();

    [Header("Touchpad")]
    public SteamVR_Action_Boolean TouchpadAction = null;
    public UnityEvent OnTouchpadDown = new UnityEvent();
    public UnityEvent OnTouchpadUp = new UnityEvent();

    [Header("Menu Button")]
    public SteamVR_Action_Boolean MenuButtonAction = null;
    public UnityEvent OnMenuButtonDown = new UnityEvent();
    public UnityEvent OnMenuButtonUp = new UnityEvent();


    private SteamVR_Behaviour_Pose Pose = null;

    private void Awake()
    {
        Pose = GetComponent<SteamVR_Behaviour_Pose>();
    }

    private void Update()
    {
        if (TriggerAction.GetStateDown(Pose.inputSource))
            OnTriggerDown.Invoke();

        if (TriggerAction.GetStateUp(Pose.inputSource))
            OnTriggerUp.Invoke();

        if (TouchpadAction.GetStateDown(Pose.inputSource))
            OnTouchpadDown.Invoke();

        if (TouchpadAction.GetStateUp(Pose.inputSource))
            OnTouchpadUp.Invoke();

        if (MenuButtonAction.GetStateDown(Pose.inputSource))
            OnMenuButtonDown.Invoke();

        if (MenuButtonAction.GetStateUp(Pose.inputSource))
            OnMenuButtonUp.Invoke();
    }

}
