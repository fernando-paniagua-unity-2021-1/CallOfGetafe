using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject[] armas;
    public float cadenciaCambioDeArma;
    private int idArmaActiva = 0;
    private bool cambioArmaDisponible = true;

    private void Start()
    {
        armas[idArmaActiva].SetActive(true);
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ApretarGatillo();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Recargar();
        }

        if (Input.mouseScrollDelta.y > 0)
        {
            CambiarArma(1);
        } 
        else if (Input.mouseScrollDelta.y < 0)
        {
            CambiarArma(-1);
        }
    }
    private void CambiarArma(int delta)
    {
        if (cambioArmaDisponible == true)
        {
            //Desactivar el arma actual
            armas[idArmaActiva].SetActive(false);
            //Incrementar el índice del arma actual
            idArmaActiva = idArmaActiva + delta;
            //Corregir el índice si es necesario
            if (idArmaActiva == armas.Length) idArmaActiva = armas.Length - 1;
            if (idArmaActiva < 0) idArmaActiva = 0;
            //Activar el nuevo arma actual
            armas[idArmaActiva].SetActive(true);
            //Desactivamos el cambio de arma
            cambioArmaDisponible = false;
            Invoke("ActivarCambioArma", cadenciaCambioDeArma);
        }
    }

    private void ActivarCambioArma()
    {
        cambioArmaDisponible = true;
    }

    private void ApretarGatillo()
    {
        //Decir al arma activa que dispare.
        print("Apretando gatillo...");
    }
    private void Recargar()
    {
        //Decir al arma activa que se recarge
        print("Recargando...");
    }
   

}
