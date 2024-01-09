using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Routine : MonoBehaviour
{
    [SerializeField]
    private Transform[] _Routine;
    // Start is called before the first frame update
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();  
    }
    void Start()
    {
        _agent.SetDestination(_Routine[pointFixe].position);
    }

    // Update is called once per frame
    void Update()
    {
        if(_agent.remainingDistance <= 1f)
        {
            pointFixe++;
        }
        if(pointFixe >= _Routine.Length )
        {
            pointFixe = 0;
        }
            _agent.SetDestination(_Routine[pointFixe].position);
    }

    private NavMeshAgent _agent;
    private int pointFixe = 0;
}
