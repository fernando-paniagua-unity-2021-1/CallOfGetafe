using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //Varibales refrentes a la salud
    public int salud = 100;
    public TextMesh texto;
    public GameObject prefabExplosion;
    public float yOffsetExplosion;

    //Resto de variables
    public string nombre;

    public void QuitarVida(int quita)
    {
        salud = salud - quita;
        if (salud <= 0)
        {
            Vector3 posicionExplosion = new Vector3(transform.position.x, transform.position.y + yOffsetExplosion, transform.position.z);
            Instantiate(prefabExplosion, posicionExplosion
                , transform.rotation);
            Destroy(gameObject);
        }
        else
        {
            texto.text = salud.ToString();
        }
    }
}
