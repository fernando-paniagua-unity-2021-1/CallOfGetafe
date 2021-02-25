using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacadorPorDistancia : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    float distanciaAtaque;
    [SerializeField]
    [Range(0,-100)]
    int danyo;

    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Claudia");
    }

    void Update()
    {
        float distancia = Vector3.Distance(player.transform.position, transform.position);
        if (distancia <= distanciaAtaque)
        {
            GetComponent<Enemigo>().Morir();
            player.GetComponent<Player>().IncrementarSalud(danyo);
        }
    }
}