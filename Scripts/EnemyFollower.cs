using UnityEngine;
using UnityEngine.AI;

public class EnemyFollower : MonoBehaviour
{
    private NavMeshAgent _enemyAgent;
    public Transform Movement;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        _enemyAgent.SetDestination(Movement.position);
    }
}
