using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        Debug.Log("Changing");
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    
}
