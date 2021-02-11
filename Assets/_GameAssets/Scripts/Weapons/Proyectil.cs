using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int danyo;
    private void OnCollisionEnter(Collision collision)
    {
        //Comprueba que ha impactado con el enemigo
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Enemigo enemigo = collision.gameObject.GetComponent<Enemigo>();
            enemigo.QuitarVida(danyo);
        }
        //Destruye el proyectil
        Destroy(gameObject);
    }
}
