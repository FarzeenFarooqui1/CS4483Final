using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotation : MonoBehaviour
{
    public float rotation = 90.0f;
    private void Start()
    {
        transform.Rotate(0, 0, rotation);
    }
}
