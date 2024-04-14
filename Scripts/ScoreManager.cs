﻿using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IScoreManager {

    [SerializeField]
    private float _score = 0;

    public TMP_Text pointsText;

    public static ScoreManager Instance;

    private void Start()
    {
        Instance = this;
    }

    public float GetScore() {
        return this._score;
    }

    public float SetScore(float score) {
        return this._score = score;
    }

    public float AddScore(float score) {
        this._score += score;
        pointsText.text = _score.ToString();
        return _score;
    }

    public float SubtractScore(float score) {
        return this._score -= score;
    }

    public float ResetScore() {
        this._score = 0;
        pointsText.text = _score.ToString();
        return _score;
    }
}