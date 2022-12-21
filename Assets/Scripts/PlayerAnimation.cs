using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] PlayerControl _playerControl;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("Run", _playerControl.InputValue != Vector2.zero);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Attack");
        }
    }
}
