using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsDemo : MonoBehaviour
{
    public Transform puntoImpacto;
    public float fuerza;
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForceAtPosition(Vector3.left * fuerza, puntoImpacto.position);
    }


}
