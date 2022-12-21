using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSimulate : MonoBehaviour
{
    public float WaterDensity = 10;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float divePercent = -transform.position.y + transform.localScale.y * 0.2f;
        divePercent = Mathf.Clamp(divePercent, 0, 1);

        _rigidbody.AddForce(Vector3.up * divePercent * WaterDensity);
        _rigidbody.drag = divePercent * 2;
        _rigidbody.angularDrag = divePercent * 2;
    }
}
