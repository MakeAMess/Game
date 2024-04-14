using UnityEngine;

public class Timer : MonoBehaviour {
    private bool _hasKey = false;
    private bool _hasExited = false;
    private float _timer = 0f; //in seconds

    private void Update() {
        if (!_hasExited) {
            _timer += Time.deltaTime;
        }

        if (_hasKey && _hasExited) {
            print("You completed the game in " + _timer * 60 + " Minutes!");
        }
    }

    public void PlayerFoundKey() {
        _hasKey = true;
    }

    public void PlayerExited() {
        if (_hasKey) {
            _hasExited = true;
        }
    }
}