using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    private Rigidbody rb;
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       playerController = GetComponent<PlayerController>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Crouch"))
        {
            playerController._speed = 10;
            Debug.Log("coucher");
        }
        if(Input.GetButtonUp("Crouch"))
        {
            playerController._speed = 15;
        }
    }
}
