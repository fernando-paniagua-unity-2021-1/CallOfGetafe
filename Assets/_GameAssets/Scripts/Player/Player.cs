using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int salud;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            QuitarSalud(1);
        }
    }
    public void QuitarSalud(int merma)
    {
        salud = salud - merma;
    }
}
