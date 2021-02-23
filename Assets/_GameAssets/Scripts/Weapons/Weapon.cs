using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public float cadencia;
    public AudioSource audioSource;
    public AudioClip sonidoDisparo;
    public AudioClip sonidoGatillazo;
    public AudioClip sonidoReload;
    public int municion;
    public abstract void Disparar();
    public abstract void Recargar();

    public void PlaySonidoDisparo()
    {
        audioSource.PlayOneShot(sonidoDisparo);
    }
    public void PlaySonidoRecarga()
    {
        audioSource.PlayOneShot(sonidoReload);
    }
}
