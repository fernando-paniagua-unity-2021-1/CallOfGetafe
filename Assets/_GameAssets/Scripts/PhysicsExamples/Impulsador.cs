using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulsador : MonoBehaviour
{
    public float fuerza;
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * fuerza);
    }
}
