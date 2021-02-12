using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneadorEnemigosSimples : MonoBehaviour
{
    public GameObject prefabEnemigo;
    public int numeroEnemigos;
    public float tiempoEntreCreaciones;
    private int enemigosCreados = 0;

    void Start()
    {
        InvokeRepeating("CrearEnemigo", 0, tiempoEntreCreaciones);
    }

    void CrearEnemigo() {
        Instantiate(prefabEnemigo, transform.position, transform.rotation);
        enemigosCreados++;
        if (enemigosCreados == numeroEnemigos)
        {
            Destroy(gameObject);
        }
    }
}