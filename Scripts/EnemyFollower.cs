using UnityEngine;
using UnityEngine.AI;

namespace DefaultNamespace
{
    public class EnemyFollower
    {
        private NavMeshAgent _agent;
        private Transform Movement;
        
        
        void FixedUpdate()
        {
            _agent.SetDestination(Movement.position);
        }
    }
}