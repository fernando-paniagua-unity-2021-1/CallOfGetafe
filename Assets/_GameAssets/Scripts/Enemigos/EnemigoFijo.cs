using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoFijo : Enemigo
{
    private void Start()
    {
        texto.text = salud.ToString();
    }
}