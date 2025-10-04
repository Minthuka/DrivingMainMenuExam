using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu3 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Prototype 5");
    }
}
