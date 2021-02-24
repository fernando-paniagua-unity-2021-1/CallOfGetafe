using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    public GameObject referenceObject;
    public Collider[] colliders;
    public float[] distance;

    private void Update()
    {
        int i;
        float distanciaActual = Vector3.Distance(referenceObject.transform.position, transform.position);
        //Desactivar todos los colliders
        for (i = 0; i < colliders.Length; i++)
        {
            colliders[i].enabled = false;
        }
        //Activar el primero que encaje la distancia
        for (i = 0; i < colliders.Length; i++)
        {
            if (distanciaActual < distance[i])
            {
                colliders[i].enabled = true;
                break;
            }
        }
        if (i == colliders.Length) colliders[colliders.Length - 1].enabled = true;
    }
}
