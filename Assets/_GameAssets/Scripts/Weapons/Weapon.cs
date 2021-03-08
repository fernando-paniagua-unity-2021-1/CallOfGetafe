    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Weapon : MonoBehaviour
{
    [Header("Configuracion")]
    public int municionTotal;//Munición total en la canana
    public int municionMaxima;//Munición máxima que admite el arma
    public int municion;//Munición actual del arma
    public float cadenciaDisparo;//Tiempo entre disparo
    public bool puedeDisparar = true;//Indica que puede disparar

    [Header("Sonido")]
    public AudioSource audioSource;
    public AudioClip sonidoDisparo;
    public AudioClip sonidoGatillazo;
    public AudioClip sonidoReload;

    [Header("UI")]
    public Sprite icon;
    public virtual void Disparar() {
        puedeDisparar = false;
        Invoke("RestaurarDisparo",cadenciaDisparo);
    }
    private void RestaurarDisparo(){
        puedeDisparar=true;
    }


    protected void Awake()
    {
        municion = municionMaxima;
    }
    public void PlaySonidoDisparo()
    {
        audioSource.PlayOneShot(sonidoDisparo);
    }
    public void PlaySonidoRecarga()
    {
        audioSource.PlayOneShot(sonidoReload);
    }
    public void PlaySonidoGatillazo()
    {
        audioSource.PlayOneShot(sonidoGatillazo);
    }
    public void Recargar()
    {
        if (municion == municionMaxima || municionTotal == 0) return;
        
        int pendientes = municionMaxima - municion;
        if (municionTotal >= pendientes)
        {
            municion += pendientes;
            municionTotal -= pendientes;
        } else
        {
            municion += municionTotal;
            municionTotal = 0;
        }
        PlaySonidoRecarga();
    }
}
