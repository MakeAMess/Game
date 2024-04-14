using UnityEngine;

public class Timer : MonoBehaviour {
    private bool _hasKey = false;
    private bool _hasExited = false;
    public static float timer = 0f; //in seconds

    private void Update() {
        if (!_hasExited) {
            timer += Time.deltaTime;
        }

        if (_hasKey && _hasExited) {
            print("You completed the game in " + timer * 60 + " Minutes!");
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