using UnityEngine;

namespace _Internal.Core.RobbersSystem
{
    public class InterestPoint : MonoBehaviour
    {
        [SerializeField] private Color color;
        [SerializeField] private float radius;
        public Vector3 Position => transform.position;

#if UNITY_EDITOR || UNITY_64
        private void OnDrawGizmos()
        {
            Gizmos.color = color;
            Gizmos.DrawSphere(transform.position, radius);
        }
#endif
    }
}
