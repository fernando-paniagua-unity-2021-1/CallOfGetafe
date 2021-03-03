using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollManager : MonoBehaviour
{
    void Awake()
    {
        //Desactivamos todos los rigidbody y collider
        Rigidbody[] rbs = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = true;
        }
        Collider[] cols = GetComponentsInChildren<Collider>();
        foreach (Collider col in cols)
        {
            col.enabled = false;
        }
        //Ponemos el Rigidbody y el Collider raiz como no kinematic
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Collider>().enabled = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Morir();
        }
    }

    public void Morir()
    {
        //Desactivamos la animación
        GetComponent<Animator>().enabled = false;
        //Activamos todos los rigidbody y todos los collider
        Rigidbody[] rbs = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = false;
        }
        Collider[] cols = GetComponentsInChildren<Collider>();
        foreach (Collider col in cols)
        {
            col.enabled = true;
        }
    }
}
