using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ComputerText : MonoBehaviour
{

    public Text cText;
    public string text;
    public bool disp = false;
    IEnumerator currentCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        cText.text = "";
        disp = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (disp)
        //{
        //    StartCoroutine(DispCoroutine());
        //}
    }

    IEnumerator DispCoroutine()
    {
        cText.text = text;
        yield return new WaitForSeconds(5);
        cText.text = "";
        disp = false;
    }

    public void set(string inp)
    {
        text = inp;
        disp = true;
        if (disp)
        {
            if(currentCoroutine != null)
            {
                StopCoroutine(currentCoroutine);
            }
            currentCoroutine = DispCoroutine();
            StartCoroutine(currentCoroutine);
        }
    }
}
