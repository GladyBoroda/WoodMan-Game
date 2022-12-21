using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goods : MonoBehaviour
{
    [SerializeField] Transform _goodsParent;
    [SerializeField] List<BlockOnBack> _blockOnBacksList=new List<BlockOnBack>();
    [SerializeField] BlockOnBack _blockOnBackPrefab;
    [SerializeField] float _offset;
    [SerializeField] int _numberOfRows;

    public static Goods Instance;
    private void Awake()
    {
        if (Instance ==null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddOne()
    {
        BlockOnBack newBlock = Instantiate(_blockOnBackPrefab, _goodsParent);
        _blockOnBacksList.Add(newBlock);
        SetPositions();
    }

    public void RemoveOne()
    {
        int lastIndex = _blockOnBacksList.Count - 1;
        if (lastIndex >=0)
        {
            Destroy(_blockOnBacksList[lastIndex].gameObject);
            _blockOnBacksList.RemoveAt(lastIndex);
        }

    }

    void SetPositions()
    {
        for (int i = 0; i < _blockOnBacksList.Count; i++)
        {
            int x = i % _numberOfRows;
            int y = i / _numberOfRows;

            _blockOnBacksList[i].transform.localPosition = new Vector3(x, y, 0)*_offset; 
        }
    }
}
