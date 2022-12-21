using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KayakMove : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public float Speed = 5;
    public float RotationSpeed = 1;
    public bool IsChracterInKayak;
    public Transform SeatPlace;

    private void LateUpdate()
    {


        if (!IsChracterInKayak)
        {
            return;
        }
        float sideForce = Input.GetAxis("Horizontal") * RotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * Speed;

        _rigidbody.AddRelativeForce(0, 0, forwardForce);
        _rigidbody.AddRelativeTorque(0, sideForce, 0);

    }

    public void SeatDownCharacter()
    {
        IsChracterInKayak = true;
    }
}
