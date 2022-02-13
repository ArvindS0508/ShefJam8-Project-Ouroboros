using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rikayon : MonoBehaviour {

    public Animator animator;
    private CharacterController controller;
    public Transform target;
    public float period = 0.01f;

    // Use this for initialization
    void Start () {
		controller = GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.LookAt(target);
            animator.SetTrigger("Attack_1");
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<GameManager>().Loop();
        }
    }

   
}
