using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTree : MonoBehaviour
{
    private Coroutine _moveProcessCoroutine;
    //[SerializeField] AnimationCurve _drodCurve;
    [SerializeField] TreeSettings _treeSettings;

    public void Drop()
    {
        if (_moveProcessCoroutine != null)
        {
            StopCoroutine(_moveProcessCoroutine);
        }
        _moveProcessCoroutine = StartCoroutine(MoveProcess());
    }
  IEnumerator MoveProcess()
    {
        float startYPosition = transform.localPosition.y;
        float endPosition = startYPosition - 1;

        for (float t = 0; t < 1f; t+=Time.deltaTime * 1.8f)
        {
            float yPosition = Mathf.Lerp(startYPosition, endPosition, _treeSettings._dropCurve.Evaluate(t));

            transform.localPosition = new Vector3(0, yPosition, 0);
            yield return null;
        }
    }
    public virtual void Die()
    {

    }
}
