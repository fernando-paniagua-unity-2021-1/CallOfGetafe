using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTonto : MonoBehaviour
{
    public string nombre;
    [Range(1, 10)]
    public float velocidad;
    [Range(1, 5)]
    public float tiempoEntreRotacion;
    [Range(-180, -45)]
    public float giroMinimo;
    [Range(45, 180)]
    public float giroMaximo;

    private void Start()
    {
        InvokeRepeating("Rotar", tiempoEntreRotacion, tiempoEntreRotacion);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
    }

    private void Rotar()
    {
        transform.Rotate(0, Random.Range(giroMinimo, giroMaximo), 0);
    }
    
}
