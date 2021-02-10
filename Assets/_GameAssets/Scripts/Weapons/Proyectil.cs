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
            //Quita la vida al enemigo
            EnemigoTonto et = collision.gameObject.GetComponent<EnemigoTonto>();
            et.QuitarVida(danyo);
        }
        //Destruye el proyectil
        Destroy(gameObject);
    }

}
