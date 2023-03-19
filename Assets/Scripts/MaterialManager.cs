using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    [SerializeField] private Renderer _cube;
    [SerializeField] private Renderer _sphere;
    [SerializeField] private Renderer _capsule;

    public void SetMaterial(Material material) {
        _cube.material = material;
        _sphere.material = material;
        _capsule.material = material;
    }

}
