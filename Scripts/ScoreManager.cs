using UnityEngine;

public class ScoreManager: IScoreManager {

    [SerializeField]
    private float _score = 0;

    public float GetScore() {
        return this._score;
    }

    public float SetScore(float score) {
        return this._score = score;
    }

    public float AddScore(float score) {
        return this._score += score;
    }

    public float SubtractScore(float score) {
        return this._score -= score;
    }

    public float ResetScore() {
        return this._score = 0;
    }
}