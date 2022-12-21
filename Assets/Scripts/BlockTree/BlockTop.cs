using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTop : BlockTree
{
    [SerializeField] Renderer _renderer;

    public override void Die()
    {
        base.Die();
        StartCoroutine(DieProcess());
    }

    IEnumerator DieProcess()
    {
        Color color = _renderer.material.color;
        for (float t = 0; t < 1; t+=Time.deltaTime)
        {
            color.a = 1 - t;
            _renderer.material.color = color;
            yield return null;
        }
        Destroy(gameObject);
    }
}
