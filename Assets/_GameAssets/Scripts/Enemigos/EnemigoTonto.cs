using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTonto : MonoBehaviour
{
    public int salud = 100;

    public TextMesh texto;

    public string nombre;
    [Range(1, 10)]
    public float velocidad;
    [Range(1, 5)]
    public float tiempoEntreRotacion;
    [Range(-180, -45)]
    public float giroMinimo;
    [Range(45, 180)]
    public float giroMaximo;

    public void QuitarVida(int quita)
    {
        salud = salud - quita;
        texto.text = salud.ToString();
    }

    private void Start()
    {
        texto.text = salud.ToString();
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
