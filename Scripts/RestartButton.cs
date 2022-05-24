using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private Button _startButton;
    [SerializeField] private PipeSpawner _spawner;
    [SerializeField] private Ground _ground;

    private void OnEnable()
    {
        _startButton.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveListener(StartGame);
    }
    public void StartGame()
    {
        _startButton.gameObject.SetActive(false);
        _bird.ResetScore();
        _bird.ResetPosition();
        _bird.ResetRotation();
        _ground.ResetPosition();
        _spawner.ResetPool();
        Time.timeScale = 1;
    }
}
