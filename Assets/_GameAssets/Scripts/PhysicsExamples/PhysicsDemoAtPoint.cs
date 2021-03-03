using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsDemoAtPoint : MonoBehaviour
{
    public Camera camara;
    public float fuerza;
    public Transform puntoImpacto;
    private void OnMouseDown()
    {
        //Aplicación de fuerza al objeto (sobre el pivote)
        //Vector3 direccion = transform.position - camara.transform.position;
        //Vector3 direccionNormalizada = direccion.normalized;
        //GetComponent<Rigidbody>().AddForce(direccionNormalizada * fuerza);

        Vector3 direccion = puntoImpacto.position - camara.transform.position;
        Vector3 direccionNormalizada = direccion.normalized;
        GetComponent<Rigidbody>().AddForceAtPosition(direccionNormalizada * fuerza, puntoImpacto.position);
    }
}
