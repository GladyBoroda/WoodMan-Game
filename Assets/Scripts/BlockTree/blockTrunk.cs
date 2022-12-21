using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockTrunk : BlockTree
{
    [SerializeField] BlockDieEffect _blockDieEffect;

    public override void Die()
    {
        base.Die();
        Instantiate(_blockDieEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
