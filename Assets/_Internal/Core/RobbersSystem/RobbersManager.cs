using UnityEngine;
using Random = UnityEngine.Random;

namespace _Internal.Core.RobbersSystem
{
    public class RobbersManager : MonoBehaviour
    {
        public static RobbersManager Instance { get; private set; }
        [SerializeField] private OutPoint outPoint;
        [SerializeField] private InterestPoint[] points;
        [SerializeField] private Robber[] robbers;

        public OutPoint OutPoint => outPoint;

        private void LaunchRobbers()
        {
            foreach (var robber in robbers)
            {
                robber.SetTarget(GetPoint());
            }
        }

        private InterestPoint GetPoint()
        {
            return points[Random.Range(0, points.Length)];
        }

        private void Awake()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) LaunchRobbers();
        }
    }
}