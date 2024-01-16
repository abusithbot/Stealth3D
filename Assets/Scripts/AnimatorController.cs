using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorController : MonoBehaviour
{
    public Animator animator;
    private PlayerController controller; //Utilise le 1er Script qui bougeais 
    public Rigidbody rb;
    InputAction Moveaction;
    public InputActionAsset actions;
    float fb; //Bouger en Face Arrière
    float lr; // Bouger en Gauche Droite

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody>(); 
    }

    private void Awake()
    {
        Moveaction = actions.FindActionMap("control").FindAction("Walk");
    }

    // Update is called once per frame
    void Update()
    {
        float fb = Moveaction.ReadValue<Vector2>().y;
        float lr = Moveaction.ReadValue<Vector2>().x;
        animator.SetFloat("Forward/Backward", fb);
        animator.SetFloat("Left/Right", lr);

       animator.SetBool("Walk", (controller._isWalking));
       animator.SetBool("Run", (controller._isRunning));    
        
       
        float v = rb.velocity.magnitude;
        if(v > 0.1) Debug.Log(v);
        
        /*anim.SetBool("Walk",true);
        animator.SetBool("Crouch",true);*/
    }

    private void OnEnable()
    {
        Moveaction.actionMap.Enable();
        actions.Enable();
    }
    private void OnDisable()
    {
        Moveaction.actionMap.Disable();
        actions.Disable();
    }
}
