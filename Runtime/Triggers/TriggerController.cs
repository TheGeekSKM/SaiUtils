using System;
using UnityEngine;
using UnityEngine.Events;

namespace SaiUtils.Triggers
{
    public class TriggerController : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] LayerMask _desiredLayer;

        [Header("Events")]
        [SerializeField] UnityEvent<GameObject> _onTriggerEnter;
        [SerializeField] UnityEvent<GameObject> _onTriggerStay;
        [SerializeField] UnityEvent<GameObject> _onTriggerExit;
        public Action<GameObject> OnTriggerEnterAction;
        public Action<GameObject> OnTriggerStayAction;
        public Action<GameObject> OnTriggerExitAction;

        void OnTriggerEnter(Collider other)
        {
            if (IsDesiredLayer(other.gameObject))
            {
                Debug.Log($"Triggered by {other.name}");
                _onTriggerEnter?.Invoke(other.gameObject);
                OnTriggerEnterAction?.Invoke(other.gameObject);
            }
        }

        void OnTriggerStay(Collider other)
        {
            if (IsDesiredLayer(other.gameObject))
            {
                Debug.Log($"Triggered by {other.name}");
                _onTriggerStay?.Invoke(other.gameObject);
                OnTriggerStayAction?.Invoke(other.gameObject);
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (IsDesiredLayer(other.gameObject))
            {
                Debug.Log($"Triggered by {other.name}");
                _onTriggerExit?.Invoke(other.gameObject);
                OnTriggerExitAction?.Invoke(other.gameObject);
            }
        }

        bool IsDesiredLayer(GameObject other)
        {
            return _desiredLayer == (_desiredLayer | (1 << other.layer));
        }
    }
}
