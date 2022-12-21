using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _lerpRate = 10;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position,Time.deltaTime * _lerpRate);
    }
}
