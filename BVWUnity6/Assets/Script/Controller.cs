using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("bool1", true);
            animator.SetBool("bool2", false);
            animator.SetBool("bool3", false);
            Debug.Log("A");
        }


        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("bool1", false);
            animator.SetBool("bool2", true);
            animator.SetBool("bool3", false);
            Debug.Log("S");
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("bool1", false);
            animator.SetBool("bool2", false);
            animator.SetBool("bool3", true);
            Debug.Log("D");
        }
    }
}