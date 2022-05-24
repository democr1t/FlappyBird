using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreText : MonoBehaviour
{
    [SerializeField] TMP_Text _text;
    [SerializeField] Bird _bird;

    private void OnEnable()
    {
        _bird.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _bird.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _text.text = score.ToString();
    }
}
