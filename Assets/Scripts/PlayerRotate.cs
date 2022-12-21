using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] float _rotationLerpSpeed = 10f;


    void Update()
    {
        if (_rigidbody.velocity != Vector3.zero)
        {
            Vector3 velocityXZ = _rigidbody.velocity;
            velocityXZ.y = 0;

            Quaternion targetRotation = Quaternion.LookRotation(velocityXZ);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * _rotationLerpSpeed);
        }
    }
}
