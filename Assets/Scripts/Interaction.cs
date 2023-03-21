using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    [SerializeField] private Clickable _clickable;
    void Update()
    {

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) { 
            if (hit.collider.TryGetComponent(out ObjectCollider objectCollider)) {
                if (Input.GetMouseButtonDown(0)) {
                    _clickable.Hit();
                }
            }
            if (hit.collider.TryGetComponent(out Cube _cube))
            {
                _cube.CollectCoins();
            }
        }

    }
}
