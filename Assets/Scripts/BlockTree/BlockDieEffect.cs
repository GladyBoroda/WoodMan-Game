using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDieEffect : MonoBehaviour
{
    [SerializeField] BlockLoot[] _blockLoots;
    [SerializeField] float _maxSpeedY = 6;
    [SerializeField] float _maxSpeedXZ = 3;

    private void Start()
    {
        for (int i = 0; i < _blockLoots.Length; i++)
        {
            Vector2 side = Random.insideUnitCircle * _maxSpeedXZ;
            float up = Random.value * _maxSpeedY;

            Vector3 velocity = new Vector3(side.x, up, side.y);

            _blockLoots[i].SetVelocity(velocity);
        }
    }

}
