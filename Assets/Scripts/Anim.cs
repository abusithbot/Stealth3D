using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Anim : MonoBehaviour
{
    public Animator animator;
    private PlayerController controller;
    public Rigidbody rb;
    PlayerInput input;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody>(); 
       
    }

    private void Awake()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
  
        
            animator.SetBool("Walk", (controller._isWalking));
            animator.SetBool("Run", (controller._isRunning));
        

       
        float v = rb.velocity.magnitude;
        if(v > 0.1) Debug.Log(v);
        

        /*anim.SetBool("Walk",true);
        animator.SetBool("Crouch",true);*/
    }
}
