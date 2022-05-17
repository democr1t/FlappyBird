using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTracker : MonoBehaviour
{
    [SerializeField] private Transform _bird;

    private Camera _camera;
    private Vector3 _offset = new Vector3(5, 0, -10);

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        _camera.transform.position = _bird.position + _offset;
    }
}
