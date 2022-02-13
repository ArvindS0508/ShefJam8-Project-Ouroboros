using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteredAirLockScript : MonoBehaviour
{
    public AirLockScript airLock;

    void OnTriggerEnter()
    {
        airLock.setTrue();
    }
}
