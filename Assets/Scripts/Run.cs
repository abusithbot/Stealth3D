using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public PlayerController controller;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Run"))
        {
            controller._speed = 0.5f;
            Debug.Log("run");
        }
        if(Input.GetButtonUp("Run"))
        {
            controller._speed = 0.2f;
        }
    }
}
