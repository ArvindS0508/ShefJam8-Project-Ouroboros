using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerTrigger : MonoBehaviour
{
    private bool triggerActive;

    public ComputerText computerText;

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
            computerText.set("The code is 12345");
    }
}
}
