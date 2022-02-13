using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("hi");
        if (collisionInfo.gameObject.name == "PlayerObject")
        {
        FindObjectOfType<GameManager>().EndGame();
        FindObjectOfType<GameManager>().Loop();
        }
    }
}
