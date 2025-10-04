using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Challenge 1");
    }
}
