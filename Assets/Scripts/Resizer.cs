using System;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField] private Vector2 _minimumSize;
    [SerializeField] private Camera _camera;
    private void Start()
    {
        OnRectTransformDimensionsChange();
    }
    private void OnRectTransformDimensionsChange()
    {
        _camera.orthographicSize = Mathf.Max(_minimumSize.x / _camera.aspect, _minimumSize.y) / 2;
    }
}
