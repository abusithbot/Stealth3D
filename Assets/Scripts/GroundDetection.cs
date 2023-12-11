using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    public float distance;
    public float gravity;
    public LayerMask groundMask; //Passer a travers les masques
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down,out hit,distance))
        {
            //touche le sol
            Debug.Log(hit.collider.gameObject.name);
            Debug.Log("t'es au sol");
        }
        else
        {

        }
        Debug.DrawRay(transform.position, Vector3.down * distance, Color.red);
        
    }
}
