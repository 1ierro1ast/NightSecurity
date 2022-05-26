using UnityEngine;

namespace _Internal.Core.RobbersSystem
{
    [RequireComponent(typeof(Robber))]
    [RequireComponent(typeof(SphereCollider))]
    public class GuardHandler : MonoBehaviour
    {
        [SerializeField] private float listenerRadius;
        private SphereCollider _trigger;
        private Robber _robber;

        private void Awake()
        {
            ValidateTrigger();
            _robber = GetComponent<Robber>();
        }

        private void ValidateTrigger()
        {
            _trigger = GetComponent<SphereCollider>();
            _trigger.radius = listenerRadius;
            _trigger.isTrigger = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Guard guard))
            {
                Debug.Log("GUARD!");
                _robber.GoToOutPoint();
            }
        }
    }
}
