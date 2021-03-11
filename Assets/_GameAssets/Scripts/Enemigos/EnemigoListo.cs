using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoListo : Enemigo
{
    [SerializeField]
    private float distanciaSeguimiento;
    [Range(0, 10)]
    public float velocidad;
    [Range(1, 5)]
    public float tiempoEntreRotacion;
    [Range(-180, -45)]
    public float giroMinimo;
    [Range(45, 180)]
    public float giroMaximo;

    private void Start()
    {
        texto.text = salud.ToString();
        InvokeRepeating("Rotar", tiempoEntreRotacion, tiempoEntreRotacion);
    }

    private void Update()
    {
        base.Update();
        if (distanciaAlPlayer <= distanciaSeguimiento)
        {
            Vector3 target = new Vector3(player.transform.position.x, 
                transform.position.y, player.transform.position.z);
            transform.LookAt(target);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
    }

    private void Rotar()
    {
        if (distanciaAlPlayer <= distanciaSeguimiento) return;
        transform.Rotate(0, Random.Range(giroMinimo, giroMaximo), 0);
    }

    public float GetDistanciaSeguimiento(){
        return distanciaSeguimiento;
    }
}
