using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void Reload(){
        Time.timeScale=1;
        SceneManager.LoadScene("Scene1");
    }
    public void Exit(){
        Time.timeScale=1;
        SceneManager.LoadScene("PortadaScene");
    }
}

