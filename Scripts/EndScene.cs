using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = SceneChanger.score.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneChanger.ChangeScene(0);
        }
    }
}
