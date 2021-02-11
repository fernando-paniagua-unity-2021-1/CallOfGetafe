using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGallina : Enemigo
{
    public float rotationSpeed;
    private void Start()
    {
        texto.text = salud.ToString();
    }
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);    
    }
}
