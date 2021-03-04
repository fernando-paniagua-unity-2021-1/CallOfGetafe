using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoFijo : Enemigo
{
    public float distanciaAtaque;
    public float velocidadRotacion;
    public Transform transformCanyon;
    public Orientador orientador;
    public TorretaDisparo torretaDisparo;
    private void Start()
    {
        texto.text = salud.ToString();
    }
    protected void Update()
    {
        base.Update();
        if (distanciaAlPlayer > distanciaAtaque)
        {
            transformCanyon.rotation = Quaternion.Euler(
                0, 
                transformCanyon.rotation.eulerAngles.y, 
                transformCanyon.rotation.eulerAngles.z);
            transformCanyon.Rotate(0, 
                velocidadRotacion * Time.deltaTime, 0);
            orientador.enabled = false;
            torretaDisparo.Pausar();
        } else
        {
            orientador.enabled = true;
            torretaDisparo.Activar();
        }
    }
}