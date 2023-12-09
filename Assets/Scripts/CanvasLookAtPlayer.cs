using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLookAtPlayer : MonoBehaviour
{
    public Transform cam;

    void LateUpdate()
    {
        transform.LookAt(cam);
    }
}
