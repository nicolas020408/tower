using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class turret : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Transform turretRotationPoint;

    [Header("Attribute")]
    [SerializeField] private float targetingRange = 5f;

    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.cyan;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);

    }
    
        
    
}
