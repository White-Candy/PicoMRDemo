using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.PXR;

public class SeethroughManager : MonoBehaviour
{

    public void Start()
    {
        ActivateSeethrough();
    }

    private void OnApplicationPause(bool pause)
    {
        if (!pause)
            ActivateSeethrough();
    }

    public void ActivateSeethrough()
    {
        PXR_Manager.EnableVideoSeeThrough = true;
    }

    public void DeactivateSeethrough()
    {
        PXR_Manager.EnableVideoSeeThrough = false;
    }
}
