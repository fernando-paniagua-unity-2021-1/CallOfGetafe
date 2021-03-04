using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilEnemigo : MonoBehaviour
{
    [SerializeField]
    [Range(0, -100)]
    int danyo;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Hacer daño al player
            collision.gameObject.GetComponent<Player>().IncrementarSalud(danyo);
        }
        Destroy(gameObject);
    }
}
