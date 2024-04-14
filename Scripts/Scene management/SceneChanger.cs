using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static float score;

    public static void ChangeScene(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }
}
