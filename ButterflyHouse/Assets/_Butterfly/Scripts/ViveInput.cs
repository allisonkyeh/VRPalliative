using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour
{
    public SteamVR_Action_Boolean GrabPinchAction;
    private SteamVR_Input_Sources inputSource;
    public ParticleSystem butterflies;

    private void OnEnable() {
        GrabPinchAction.AddOnStateDownListener(Press, inputSource);
        GrabPinchAction.AddOnStateUpListener(PressUp, inputSource);
    }

    private void Press (SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log ("press!!");
        butterflies.Play();
    }
    private void PressUp (SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log ("press UP!!");
        butterflies.Stop();
    }

}
