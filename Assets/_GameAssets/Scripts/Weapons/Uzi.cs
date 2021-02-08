using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    public GameObject prefabProyectil;
    public float fuerzaDisparo;
    public GameObject puntoSpawn;
    public override void Disparar()
    {
        PlaySonidoDisparo();
        GameObject proyectil = Instantiate(prefabProyectil, puntoSpawn.transform.position, puntoSpawn.transform.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(puntoSpawn.transform.forward * fuerzaDisparo);
    }

    public override void Recargar()
    {
        PlaySonidoRecarga();
    }
}
