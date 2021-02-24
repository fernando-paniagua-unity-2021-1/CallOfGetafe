using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ////Por el nombre
        //if (collision.gameObject.name == "Cube")
        //{
        //    print("He chocado contra el cubo");
        //}
        //Por el tag
        if (collision.gameObject.CompareTag("Muro"))
        {
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Muro"))
        {
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
        }
    }
}
