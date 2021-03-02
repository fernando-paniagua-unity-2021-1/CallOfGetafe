using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon[] armas;
    public float cadenciaCambioDeArma;
    private int idArmaActiva = 0;
    private bool cambioArmaDisponible = true;

    private void Start()
    {
        armas[idArmaActiva].gameObject.SetActive(true);
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


        //Cambio de arma con rueda del ratón
        if (Input.mouseScrollDelta.y > 0)
        {
            CambiarArma(1);
        } 
        else if (Input.mouseScrollDelta.y < 0)
        {
            CambiarArma(-1);
        }

        //Cambio de arma con número
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CambiarArmaPorNumero(0);
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CambiarArmaPorNumero(1);
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CambiarArmaPorNumero(2);
        }

    }
    private void DesactivarZoomSnipper()
    {
        //Si está el Snipper activo, restaurar el estado por si está en modo Zoom
        if (armas[idArmaActiva].GetComponent<Snipper>() != null)
        {
            armas[idArmaActiva].GetComponent<Snipper>().RestaurarEstado();
        }
    }
    private void CambiarArma(int delta)
    {
        if (cambioArmaDisponible == true)
        {
            DesactivarZoomSnipper();
            //Desactivar el arma actual
            armas[idArmaActiva].gameObject.SetActive(false);
            //Incrementar el índice del arma actual
            idArmaActiva = idArmaActiva + delta;
            //Corregir el índice si es necesario
            if (idArmaActiva == armas.Length) idArmaActiva = armas.Length - 1;
            if (idArmaActiva < 0) idArmaActiva = 0;
            //Activar el nuevo arma actual
            armas[idArmaActiva].gameObject.SetActive(true);
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
        armas[idArmaActiva].Disparar();
    }
    private void Recargar()
    {
        //Decir al arma activa que se recarge
        print("Recargando...");
        armas[idArmaActiva].Recargar();
    }
    private void CambiarArmaPorNumero(int nuevoIdArma)
    {
        DesactivarZoomSnipper();
        armas[idArmaActiva].gameObject.SetActive(false);
        idArmaActiva = nuevoIdArma;
        armas[idArmaActiva].gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Municion"))
        {
            armas[idArmaActiva].municionTotal += other.gameObject.GetComponent<AmmoItem>().GetMunicion();
            Destroy(other.gameObject);//Destrucción de la maleta
        }
    }
    public int GetCurrentAmmo()
    {
        return armas[idArmaActiva].municion;
    }
    public int GetTotalAmmo()
    {
        return armas[idArmaActiva].municionTotal;
    }
    public string GetCurrentWeaponName()
    {
        return armas[idArmaActiva].name;
    }
    public Sprite GetCurrentWeaponIconSprite()
    {
        return armas[idArmaActiva].icon;
    }
}
