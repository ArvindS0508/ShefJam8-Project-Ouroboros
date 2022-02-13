using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplescript : MonoBehaviour
{
    public bool dir = true;
    // Start is called before the first frame update
    void Start()
    {
        //launch();
    }

    // Update is called once per frame
    public void launch()
    {
        if (dir)
        {
            GetComponent<Rigidbody>().AddForce(-100, 0, 0);
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 100);
        }

        Destroy(this);
        
    }
}
