using UnityEngine;
using UnityEngine.AI;

namespace _Internal.Core.RobbersSystem
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Robber : MonoBehaviour
    {
        private NavMeshAgent _agent;
        private RobbersManager _robbersManager;

        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        private void Start()
        {
            _robbersManager = RobbersManager.Instance;
        }

        public void SetTarget(InterestPoint target)
        {
            _agent.SetDestination(target.Position);
        }

        public void GoToOutPoint()
        {
            SetTarget(_robbersManager.OutPoint);
        }

        private void Update()
        {
            _agent.Move(Vector3.zero);
        }
    }
}