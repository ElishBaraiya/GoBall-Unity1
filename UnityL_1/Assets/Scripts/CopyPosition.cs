using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform TransTarget;

    void FixedUpdate()
    {
        transform.position = TransTarget.position;
        transform.LookAt(TransTarget);
    }
}
