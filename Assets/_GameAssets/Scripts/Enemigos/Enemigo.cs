﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //Variables referentes a la salud
    public int salud = 100;
    public TextMesh texto;
    
    public GameObject prefabExplosion;
    public float yOffsetExplosion;
    public GameObject prefabSangre;
    public GameObject prefabBulletHole;

    public AudioClip sonidoDolor;
    public AudioSource fuenteSonido;

    //Resto de variables
    public string nombre;

    public void QuitarVida(int quita, ContactPoint punto)
    {
        //Grita
        if (sonidoDolor != null)
        {
            fuenteSonido.PlayOneShot(sonidoDolor);
        }
        //Generamos la sangre
        Vector3 posicion = new Vector3(punto.point.x, punto.point.y, punto.point.z);
        GameObject sangre = Instantiate(prefabSangre, posicion, transform.rotation);
        sangre.transform.rotation = Quaternion.FromToRotation(Vector3.forward, punto.normal);
        //Generamos la marca del disparo (sólo si hay prefab de la marca)
        if (prefabBulletHole != null)
        {
            GameObject marcaTiro = Instantiate(prefabBulletHole, posicion, transform.rotation);
            marcaTiro.transform.rotation = Quaternion.FromToRotation(Vector3.forward, punto.normal);
            marcaTiro.transform.SetParent(punto.otherCollider.transform);//Asignamos al enemigo como padre del bullet hole
        }
        //Resta la quita a la salud
        salud = salud - quita;
        //Si la salud es menor o igual que 0, tiene que morir
        if (salud <= 0)
        {
            //Generamos la explosión
            Vector3 posicionExplosion = new Vector3(transform.position.x, 
                transform.position.y + yOffsetExplosion, transform.position.z);
            if (prefabExplosion != null)//Condición de 'existencia'
            {
                Instantiate(prefabExplosion, posicionExplosion
                , transform.rotation);
                //Destruimos el objeto
                Destroy(gameObject);
            }
        }
        else
        {
            //Actualizamos la barra de salud
            if (texto!=null)
            {
                texto.text = salud.ToString();
            }
        }
    }
}
