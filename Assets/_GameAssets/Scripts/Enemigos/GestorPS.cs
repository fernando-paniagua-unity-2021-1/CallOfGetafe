using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorPS : MonoBehaviour
{
    public ParticleSystem ps;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Asfalto"))
        {
            //Desactivar el PS
            ps.Stop();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Asfalto"))
        {
            //Activar el PS
            ps.Play();
        }
    }
}
