using UnityEngine;
using UnityEngine.Events;
using System;

namespace SaiUtils.Triggers
{
    public class Trigger2DController : MonoBehaviour
    {[Header("Settings")]
        [SerializeField] LayerMask _desiredLayer;

        [Header("Events")]
        [SerializeField] UnityEvent<GameObject> _onTriggerEnter;
        [SerializeField] UnityEvent<GameObject> _onTriggerStay;
        [SerializeField] UnityEvent<GameObject> _onTriggerExit;
        public Action<GameObject> OnTriggerEnterAction;
        public Action<GameObject> OnTriggerStayAction;
        public Action<GameObject> OnTriggerExitAction;

        void OnTriggerEnter2D(Collider2D other)
        {
            if (IsDesiredLayer(other.gameObject))
            {
                Debug.Log($"Triggered by {other.name}");
                _onTriggerEnter?.Invoke(other.gameObject);
                OnTriggerEnterAction?.Invoke(other.gameObject);
            }
        }

        void OnTriggerStay2D(Collider2D other)
        {
            if (IsDesiredLayer(other.gameObject))
            {
                Debug.Log($"Triggered by {other.name}");
                _onTriggerStay?.Invoke(other.gameObject);
                OnTriggerStayAction?.Invoke(other.gameObject);
            }
        }

        void OnTriggerExit2D(Collider2D other)
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
