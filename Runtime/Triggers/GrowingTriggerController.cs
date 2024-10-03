using DG.Tweening;
using SaiUtils.Extensions;
using UnityEngine;

namespace SaiUtils.Triggers
{
    [RequireComponent(typeof(TriggerController))]
    public class GrowingTriggerController : MonoBehaviour
    {
        [SerializeField] TriggerController _triggerController;
        [SerializeField] float _finalVisionRadius = 10f;
        bool initialized = false;

        public void Initialize(float finalRadius, float existTime)
        {
            _finalVisionRadius = finalRadius;
            initialized = true;

            if (!_triggerController) _triggerController = gameObject.GetOrAdd<TriggerController>();

            // set the scale of the trigger to 0.1f
            _triggerController.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

            transform.DOScale(_finalVisionRadius, existTime).SetEase(Ease.Linear);

            // set the trigger to destroy itself after the exist time
            Destroy(gameObject, existTime + 3f);
        }

       
    }
}