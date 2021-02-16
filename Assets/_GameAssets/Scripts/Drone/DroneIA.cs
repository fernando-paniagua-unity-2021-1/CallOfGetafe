using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DroneIA : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform[] puntosPatrullaje;
    public bool navegacionSecuencial;

    private int puntoActual = 0;
    private int puntoSiguiente;
    private void Start()
    {
        agente.SetDestination(puntosPatrullaje[puntoActual].position);
    }
    private void Update()
    {
        if (agente.remainingDistance <= agente.stoppingDistance)
        {
            if (navegacionSecuencial)
            {
                puntoSiguiente=puntoActual+1;
            } else
            {
                do
                {
                    //Si sólo hay un punto de patrullaje, sale del bucle
                    if (puntosPatrullaje.Length==1) break;
                    puntoSiguiente = Random.Range(0, puntosPatrullaje.Length);
                } while (puntoSiguiente == puntoActual);
            }
            puntoActual = puntoSiguiente;
            if (puntoActual==puntosPatrullaje.Length) {
                puntoActual = 0;
            }
            agente.SetDestination(puntosPatrullaje[puntoActual].position);
        }
    }
}
