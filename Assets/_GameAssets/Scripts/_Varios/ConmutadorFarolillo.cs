using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConmutadorFarolillo : MonoBehaviour
{

    Rigidbody x;
    public Light luz1;
    public Light luz2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Claudia")
        {
            luz1.enabled = true;
            luz2.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Claudia")
        {
            luz1.enabled = false;
            luz2.enabled = false;
        }
    }
}
