using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator anim;
    private PlayerController controller;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Forward/Backward", rb.velocity.magnitude);
        anim.SetFloat("Left/Right", rb.velocity.magnitude);

        if (Input.GetButton("up"))
        {
            anim.SetBool("Walk", true);
        }

        /*anim.SetBool("Walk",true);
        anim.SetBool("Run",true);
        anim.SetBool("Crouch",true);
        float v = rb.velocity.magnitude;
        if(v > 0.1) Debug.Log(v);*/
    }
}
