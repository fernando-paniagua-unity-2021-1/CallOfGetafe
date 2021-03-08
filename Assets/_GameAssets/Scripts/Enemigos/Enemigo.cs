using System.Collections;
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

    //Referencia al player //**
    protected GameObject player; //**
    protected float distanciaAlPlayer; //**

    private void Awake()//**
    { //**
        GameObject.Find("GameManager").GetComponent<GameManager>().AddEnemigo();
        player = GameObject.Find("Claudia"); //**
    } //**

    protected void Update() //**
    { //**
        distanciaAlPlayer = Vector3.Distance(transform.position, //**
            player.transform.position); //**
    } //**

    public void QuitarVida(int quita, ContactPoint punto)
    {
        QuitarVida(
            quita,
            new Vector3(punto.point.x, punto.point.y, punto.point.z),
            punto.normal,
            punto.otherCollider.transform);
    }

    public void QuitarVida(int quita, Vector3 posicionImpacto, Vector3 normal, Transform parent)
    {
        //Grita
        if (sonidoDolor != null)
        {
            fuenteSonido.PlayOneShot(sonidoDolor);
        }
        //Generamos la sangre
        Vector3 posicion = new Vector3(posicionImpacto.x, posicionImpacto.y, posicionImpacto.z);
        GameObject sangre = Instantiate(prefabSangre, posicion, transform.rotation);
        sangre.transform.rotation = Quaternion.FromToRotation(Vector3.forward, normal);
        //Generamos la marca del disparo (sólo si hay prefab de la marca)
        if (prefabBulletHole != null)
        {
            GameObject marcaTiro = Instantiate(prefabBulletHole, posicion, transform.rotation);
            marcaTiro.transform.rotation = Quaternion.FromToRotation(Vector3.forward, normal);
            marcaTiro.transform.SetParent(parent);//Asignamos al enemigo como padre del bullet hole
        }
        //Resta la quita a la salud
        salud = salud - quita;
        //Si la salud es menor o igual que 0, tiene que morir
        if (salud <= 0)
        {
            Morir();
            salud = 0;
        }
        //Actualizamos la barra de salud
        if (texto != null)
        {
            texto.text = salud.ToString();
        }
    }
    
    public void Morir()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().QuitarEnemigo();
        if (GetComponent<RagdollManager>() == null) {
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
        } else
        {
            //Este bloque de código solo sirve para este caso concreto (EnemigoTonto + Ragdoll)
            GetComponent<EnemigoTonto>().Desactivar();
            GetComponent<RagdollManager>().Morir();
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<AtacadorPorDistancia>().enabled = false;
        }
    }
}