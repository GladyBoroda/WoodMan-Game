using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField] float _attackRadius = 1f;
    [SerializeField] Animator _animator;

    bool _attack;
    
    void Update()
    {
        if (_attack == false)
        {
            Collider[] allColliders = Physics.OverlapSphere(transform.position, _attackRadius);
            for (int i = 0; i < allColliders.Length; i++)
            {
                if (allColliders[i].TryGetComponent(out TreeCollider treeCollider))
                {
                    StartAttack();
                    break;
                    //treeCollider.Tree.TakeHit();
                }


            }
        }
        

    }
    public void StopAttack()
    {
        _attack = false;
    }

    public void DoAttack()
    {
        Collider[] allColliders = Physics.OverlapSphere(transform.position, _attackRadius);
        for (int i = 0; i < allColliders.Length; i++)
        {
            if (allColliders[i].TryGetComponent(out TreeCollider treeCollider))
            {
                treeCollider.Tree.TakeHit();
            }


        }
    }
    void StartAttack()
    {
        _animator.SetTrigger("Attack");
        _attack = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere( transform.position,_attackRadius);
    }
}
