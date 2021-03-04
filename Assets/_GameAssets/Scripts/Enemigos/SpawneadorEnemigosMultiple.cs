using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneadorEnemigosMultiple : MonoBehaviour
{
    public GameObject[] prefabEnemigos;
    public int numeroEnemigos;
    public float tiempoEntreCreaciones;
    private int enemigosCreados = 0;

    void Start()
    {
        InvokeRepeating("CrearEnemigo", 0, tiempoEntreCreaciones);
    }

    void CrearEnemigo() {
        int x = Random.Range(0, prefabEnemigos.Length);
        Instantiate(prefabEnemigos[x], transform.position, transform.rotation);
        enemigosCreados++;
        if (enemigosCreados == numeroEnemigos)
        {
            Destroy(gameObject);
        }
    }
}