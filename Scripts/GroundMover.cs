using UnityEngine;

public class GroundMover : MonoBehaviour
{
    [SerializeField] private Ground _ground;
    [SerializeField] private float _speed;

    private void Update()
    {
        _ground.transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
