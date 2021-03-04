using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaDisparo : MonoBehaviour
{
    public GameObject prefabProyectil;
    public float tiempoEntreDisparos;
    public float fuerzaDisparo;
    public GameObject puntoSpawn;
    private bool activado = false;
    void Start()
    {
        Activar();
    }
    void Disparar()
    {
        GameObject proyectil = Instantiate(prefabProyectil, 
            puntoSpawn.transform.position, 
            puntoSpawn.transform.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(
            puntoSpawn.transform.forward * fuerzaDisparo);
    }
    public void Pausar()
    {
        CancelInvoke("Disparar");
        activado = false;
    }
    public void Activar()
    {
        if (activado) return;
        InvokeRepeating("Disparar", tiempoEntreDisparos, 
            tiempoEntreDisparos);
        activado = true;
    }
}
