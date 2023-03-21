using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMaterial : MonoBehaviour
{
    [SerializeField] private Renderer _cube;

    public void SetMaterial(Material material)
    {
        _cube.material = material;
    }
}
