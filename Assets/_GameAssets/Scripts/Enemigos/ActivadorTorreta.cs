using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorTorreta : MonoBehaviour
{
    private float distanciaAlPlayer;
    private float distanciaSeguimiento;
    void Start()
    {
        distanciaSeguimiento = GetComponent<EnemigoListo>().GetDistanciaSeguimiento();
    }

    // Update is called once per frame
    void Update()
    {
        distanciaAlPlayer = GetComponent<Enemigo>().GetDistanciaAlPlayer();
        if (distanciaAlPlayer<distanciaAlPlayer){
            GetComponent<TorretaDisparo>().Activar();
        }  else {
            GetComponent<TorretaDisparo>().Pausar();
        }
    }
}
