using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField input;

    void Awake()
    {
        SystemManager.Instance.LoadPlayerData();
    }

    public void StartGame()
    {
        SystemManager.Instance.PlayerName = input.text;
        SceneManager.LoadScene(1);
    }
}
