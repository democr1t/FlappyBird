using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    private int _score;
    private Vector3 _startPosition;
    private Quaternion _startRotation;
    public int Score => _score;

    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        Time.timeScale = 1;
        _startButton.gameObject.SetActive(false);
        _startPosition = transform.position;
        _startRotation = transform.rotation;
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void ResetPosition()
    {
        transform.position = _startPosition;
    }

    public void ResetScore()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
    }

    public void ResetRotation()
    {
        transform.rotation = _startRotation;
    }

    public void Die()
    {
        Time.timeScale = 0;
        _startButton.gameObject.SetActive(true);
    }
}
