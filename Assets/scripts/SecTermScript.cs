using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecTermScript : MonoBehaviour
{
    private bool triggerActive;

    public ComputerText computerText;

    public string message = "Alien creature detected. Temporal self destruct has been activated.";

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetButtonDown("Interact"))
        {
            computerText.set(message);
        }
    }
}
