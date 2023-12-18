using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
    public Animator anim;
    private PlayerController controller;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
      /*  anim.SetFloat("Forward/Backward", rb.velocity.magnitude);
        anim.SetFloat("Left/", rb.velocity.magnitude);*/
    }
}
