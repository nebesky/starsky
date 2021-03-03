using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour
{
    void OnDrawGizmos()
    {
        UnityEditor.Handles
        .DrawWireDisc(Vector3.zero ,Vector3.back, 100f);
        UnityEditor.Handles
        .DrawWireDisc(Vector3.zero ,Vector3.back, 110f);
    }
}
