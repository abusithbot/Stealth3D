using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float _speed;
    private InputAction Move;
    public InputActionAsset _asset;
    Vector3 direction;
    Vector2 mouvement;
    private GroundDetection _groundDetection;
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

      
        CharacterController characterController = GetComponent<CharacterController>();
        direction = Camera.main.transform.forward;
        Vector3 mouvForward = Camera.main.transform.forward * y;
        Vector3 mouvRignt = Camera.main.transform.right * x;
        Vector3 mouvFinal = mouvRignt + mouvForward;
        mouvFinal.y = 0; 
        direction = new Vector3 (x,0,y);
        direction *= _speed * Time.deltaTime;

        if(_groundDetection.IsGrounded)
        {
          characterController.Move(mouvFinal* _speed * Time.deltaTime);
        }
        Debug.DrawRay(transform.position,direction * 10, Color.red);
    }
    // Update is called once per frame
}
