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
            Enemigo enemigo = collision.gameObject.GetComponentInParent<Enemigo>();
            enemigo.QuitarVida(danyo, collision.GetContact(0));
        }
        //Destruye el proyectil
        Destroy(gameObject);
    }
}
