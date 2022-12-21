using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] int _healh = 3;
    [SerializeField] List<BlockTree> _blocks = new List<BlockTree>();
    [SerializeField] Collider _collider;

    private bool _isDead;
    public void TakeHit()
    {
        if (_isDead) return;
        _healh--;

        _blocks[0].Die();
        _blocks.RemoveAt(0);
        for (int i = 0; i < _blocks.Count; i++)
        {
            _blocks[i].Drop();
        }

        if (_healh <= 0)
        {
            Die();
        }

        void Die()
        {
            _isDead = true;
            _collider.enabled = false;
            _blocks[0].Die();
            Destroy(gameObject, 2);
        }
    }
}
