using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}
