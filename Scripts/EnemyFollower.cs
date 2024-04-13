using UnityEngine;
using UnityEngine.AI;

public class EnemyFollower
{
    private NavMeshAgent _agent;
    private Transform Movement;
        
        
    void FixedUpdate()
    {
        _agent.SetDestination(Movement.position);
    }
}