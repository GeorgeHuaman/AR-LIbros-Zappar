using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zappar;

public class TouchHandler : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    private bool isSplit;
    [SerializeField]
    private ZapparInstantTrackingTarget m_instantTracker;

    private void Update()
    {
#if UNITY_EDITOR
        if (animator != null && Input.GetMouseButtonDown(0))
#else
        if (animator != null && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
#endif
        {
            if (m_instantTracker.UserHasPlaced)
                isSplit = !isSplit;
                animator.SetBool("isSplit",isSplit);
        }
    }
}
