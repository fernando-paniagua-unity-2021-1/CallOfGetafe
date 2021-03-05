﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("Scene1");
    }
    public void Config(){
        print("CONFIG");
    }
    public void Exit(){
        Application.Quit();
    }
}
