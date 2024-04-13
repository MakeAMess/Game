using UnityEngine;
using UnityEngine.AI;

public class EnemyFollower : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Transform _playerTransform;
    private float _fieldOfView = 60f; // Field of view in degrees
    private Vector3[] _path; // The path the enemy should follow
    private int _currentPathIndex;

    private void Start()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        _agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        if (IsPlayerInFieldOfView())
        {
            _agent.SetDestination(_playerTransform.position);
        }
        else
        {
            FollowPath();
        }
    }

    private bool IsPlayerInFieldOfView()
    {
        Vector3 directionToPlayer = _playerTransform.position - transform.position;
        float angle = Vector3.Angle(transform.forward, directionToPlayer);
        return angle < _fieldOfView / 2;
    }

    private void FollowPath()
    {
        if (_path.Length == 0)
            return;

        _agent.SetDestination(_path[_currentPathIndex]);

        if (_agent.remainingDistance < _agent.stoppingDistance)
        {
            _currentPathIndex = (_currentPathIndex + 1) % _path.Length;
        }
    }
}