using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private BoxCollider _colliderBox;
    [SerializeField] private SphereCollider _colliderSphere;
    [SerializeField] private MeshCollider _colliderCylinder;
    public void SetScale(float value)
    {
        transform.localScale = Vector3.one * value;
        _colliderBox.size = Vector3.one * value;
        _colliderSphere.radius = value; 
    }

}
