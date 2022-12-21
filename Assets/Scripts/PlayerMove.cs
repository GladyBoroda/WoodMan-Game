using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] float _speed;
    [SerializeField] PlayerControl _playerControl ;

   

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_playerControl.InputValue.x, 0, _playerControl.InputValue.y) * _speed;
    }
}
