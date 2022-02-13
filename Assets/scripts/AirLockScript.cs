using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AirLockScript : MonoBehaviour
{
    public bool EnteredAirLockFlag = false;

    //public BreakableWindow bw1;
    //public BreakableWindow bw2;
    public samplescript s1;
    public samplescript s2;

    private bool once;

    public AudioClip breakingSound;

    void Start()
    {
        EnteredAirLockFlag = false;
        once = true;
    }

    void OnTriggerEnter()
    {
        if (EnteredAirLockFlag && once)
        {
            once = false;
            GetComponent<AudioSource>().clip = breakingSound;
            GetComponent<AudioSource>().Play();
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<GameManager>().Loop();
        }

    }

    public void setTrue()
    {
        EnteredAirLockFlag = true;
    }
}
