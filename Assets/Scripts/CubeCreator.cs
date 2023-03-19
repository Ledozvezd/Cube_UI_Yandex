using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private int _amountOfCubes = 3;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Resources _resources;
    public void Create()
    {
        for (int i = 0; i < _amountOfCubes; i++)
        {
            Cube cube = Instantiate(_cubePrefab, transform.position, Quaternion.identity);

            Vector3 velocity = Vector3.up;
            float x = Random.Range(-45f, 45f);
            float y = Random.Range(-180f, 180f);

            velocity = Quaternion.Euler(x, y, 0) * velocity;

            cube.SetUp(velocity * _speed, _resources);
        }
    }
}
