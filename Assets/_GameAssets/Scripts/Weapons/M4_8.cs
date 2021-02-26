using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4_8 : Weapon
{
    [Header("Específicos M4_8")]
    public GameObject prefabProyectil;
    public float fuerzaDisparo;
    public GameObject puntoSpawn;
    public override void Disparar()
    {
        if (municion > 0)
        {
            PlaySonidoDisparo();
            GameObject proyectil = Instantiate(prefabProyectil, puntoSpawn.transform.position, puntoSpawn.transform.rotation);
            proyectil.GetComponent<Rigidbody>().AddForce(puntoSpawn.transform.forward * fuerzaDisparo);
            municion--;//¡¡NO OLVIDAR RESTAR UNO A LA MUNICIÓN!!
        } else
        {
            PlaySonidoGatillazo();
        }
    }
}
