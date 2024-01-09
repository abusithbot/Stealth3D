using UnityEngine;
using UnityEngine.AI;

public class stalk : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    Vector3 SetDestination;
    void Update()
    {
      enemy.SetDestination(Player.position);
    }
}
