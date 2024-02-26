using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] float detectionDistance = 3f;
    [SerializeField] Vector2 direction => transform.parent.localScale.x < 0 ? Vector2.right : Vector2.left;
    [SerializeField] LayerMask layerMask;
    RaycastHit2D[] colliders = new RaycastHit2D[1];
    public bool isDetected = false;
    private void Update()
    {
        Physics2D.RaycastNonAlloc(transform.position, direction, colliders, detectionDistance, layerMask);
        if (colliders[0].collider?.tag == "Player")
            isDetected = true;
        else
            isDetected = false;
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, direction * detectionDistance);
    }
}
