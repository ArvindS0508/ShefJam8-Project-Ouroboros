using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ComputerText computerText;

    public void EndGame()
    {
        Debug.Log("Loop");
    }

    public void Loop()
    {
        StartCoroutine(LoopCoroutine());
    }

    IEnumerator LoopCoroutine()
    {
        computerText.set("You Died");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
