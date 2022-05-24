using UnityEngine;

public class Ground : MonoBehaviour
{
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = _startPosition;
    }
}
