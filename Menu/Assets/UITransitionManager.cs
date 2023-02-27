using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITransitionManager : MonoBehaviour
{
    public CinemachineVirtualCamera currentCamera;

    

    public void UpdateCamera(CinemachineVirtualCamera target)
    {
        currentCamera.Priority = 0;
        currentCamera = target;
        currentCamera.Priority = 10;
        
    }
}
