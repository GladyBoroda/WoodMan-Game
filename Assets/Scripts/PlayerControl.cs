using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerControl : MonoBehaviour
{
    private Vector3 _startMousePosition;

    public Vector2 InputValue;
    public KayakMove KayakMove;
    public Rigidbody Rigidbody;

    private void Update()
    {
          
        if (Input.GetMouseButtonDown(0))
        {
            _startMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {

            Vector3 delta = (Input.mousePosition - _startMousePosition) / 50f;
            float magnitude = delta.magnitude;
            float clampMagnitude = Mathf.Clamp(magnitude, 0, 1);

            Vector3 deltaNormalized = delta.normalized * clampMagnitude;
            InputValue = new Vector2(deltaNormalized.x, deltaNormalized.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            InputValue = Vector2.zero;
        }


    }

    private void SeatToKayak()
    {
        KayakMove.SeatDownCharacter();
        transform.SetParent(KayakMove.SeatPlace);

        //todo
        Rigidbody.isKinematic = true;
        Rigidbody.useGravity = false;


        KayakMove._rigidbody.velocity = Vector3.zero;
    }
    public void StartJump()
    {
        transform.DOJump(KayakMove.SeatPlace.transform.position, 10, 1, 2).onComplete += SeatToKayak;
    }
}

