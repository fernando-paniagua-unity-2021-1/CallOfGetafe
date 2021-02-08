using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaDisparo : MonoBehaviour
{
    public GameObject prefabProyectil;
    public float tiempoEntreDisparos;
    public float fuerzaDisparo;
    public GameObject puntoSpawn;
    void Start()
    {
        InvokeRepeating("Disparar", tiempoEntreDisparos, tiempoEntreDisparos); 
    }

    void Disparar()
    {
        GameObject proyectil = Instantiate(prefabProyectil, puntoSpawn.transform.position, puntoSpawn.transform.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(puntoSpawn.transform.forward * fuerzaDisparo);
    }
}
