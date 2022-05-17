using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMover : MonoBehaviour
{
    [SerializeField] private float _maxRotation;
    [SerializeField] private float _minRotation;
    [SerializeField] private float _tapForce = 300;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private float _moveSpeed;

    private Rigidbody2D _rigidbody2D;

    private Quaternion _maxRotationZ = Quaternion.Euler(0,0, _maxRotation);
    private Quaternion _minRotationZ = Quaternion.Euler(0, 0, _minRotation);
    

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        CheckInput();
        Rotate();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_moveSpeed, 0);
            _rigidbody2D.AddForce(Vector2.up * _tapForce);
            transform.rotation = _maxRotationZ;
        }     
    }

    private void Rotate()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotationZ, _rotationSpeed * Time.deltaTime);
    }
}
