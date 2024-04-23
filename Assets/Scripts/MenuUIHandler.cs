using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        SystemManager.Instance.SavePlayerData();
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }

    public void SaveEnteredName()
    {
        SystemManager.Instance.SavePlayerData();
    }

    public void LoadEnteredName()
    {
        SystemManager.Instance.LoadPlayerData();
    }
   
}
