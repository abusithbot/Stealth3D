using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float _speed = 0.2f;
    private InputAction Move;
    public InputActionAsset _asset;
    Vector3 direction;
    Vector2 mouvement;
    private GroundDetection _groundDetection;
    private Rigidbody rb;
    public bool _isWalking;
    public bool _isRunning;
    // Start is called before the first frame update

    private void Awake()
    {
        Move = _asset.FindActionMap("control").FindAction("Walk");
        Move.Enable();
       _groundDetection = GetComponent<GroundDetection>();
           
    }
    void Update()
    {
       float y = Move.ReadValue<Vector2>().y;
       float x = Move.ReadValue<Vector2>().x;
        Debug.Log(y + " " + x);
        _isWalking = Move.ReadValue<Vector2>().magnitude > 0.1;
        _isRunning = Move.ReadValue<Vector2>().magnitude > 0.9;

      
        rb = GetComponent<Rigidbody>();
        direction = Camera.main.transform.forward;
        Vector3 mouvForward = Camera.main.transform.forward * y;
        Vector3 mouvRignt = Camera.main.transform.right * x;
        Vector3 mouvFinal = mouvRignt + mouvForward;
        mouvFinal.y = 0; 
        direction = new Vector3 (x,0,y);
        direction *= _speed * Time.deltaTime;

        /*if(_groundDetection.IsGrounded)
        {
          rb.MovePosition(mouvFinal* _speed * Time.deltaTime);
        }
        Debug.DrawRay(transform.position,direction * 10, Color.red);*/
    }
    // Update is called once per frame

    private void FixedUpdate()
    {
        float y = Move.ReadValue<Vector2>().y;
        float x = Move.ReadValue<Vector2>().x;
        Debug.Log(y + " " + x);


        rb = GetComponent<Rigidbody>();
        direction = Camera.main.transform.forward;
        Vector3 mouvForward = Camera.main.transform.forward * y;
        Vector3 mouvRignt = Camera.main.transform.right * x;
        Vector3 mouvFinal = mouvRignt + mouvForward;
        mouvFinal.y = 0;

        if (_groundDetection.IsGrounded)
        {
            rb.MovePosition(transform.position + mouvFinal * _speed);
        }
        Debug.DrawRay(transform.position, direction * 10, Color.red);
    }
}
