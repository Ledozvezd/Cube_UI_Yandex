using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    private Resources _resources;
    public void SetUp(Vector3 velocity, Resources resources)
    {
        _resources = resources;
        _rb.velocity = velocity;
    }
    public void CollectCoins()
    {
        _resources.CollectCoins(1, transform.position);
        Destroy(gameObject);
    }
}
