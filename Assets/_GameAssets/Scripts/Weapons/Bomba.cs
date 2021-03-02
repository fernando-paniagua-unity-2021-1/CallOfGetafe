using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    //Hay que crear una capa para filtrar los colliders que no queremos manejar-->PUNTO 1
    //Los objetos que queremos explotar tienen el tag "Enemigo"-->PUNTO 2
    public float distancia;
    public float fuerza;
    public float fuerzaVertical;
    public LayerMask layerMask;
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.B)) 
        {
            Collider[] colisionadores = Physics.OverlapSphere(transform.position, distancia, layerMask);//PUNTO 1
            foreach(Collider c in colisionadores)
            {
                if (c.gameObject.CompareTag("Enemigo"))//PUNTO 2
                {
                    Rigidbody rb = c.gameObject.GetComponentInParent<Rigidbody>();
                    rb.isKinematic = false;
                    rb.AddExplosionForce(fuerza, transform.position, distancia, fuerzaVertical);
                }
            }
        }
    }
}