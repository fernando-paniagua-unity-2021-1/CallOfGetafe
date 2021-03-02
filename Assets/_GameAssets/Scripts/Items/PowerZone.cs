using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerZone : MonoBehaviour
{
    [SerializeField]
    [Range(1,100)]
    int deltaSalud;
    [SerializeField]
    [Range(0.1f, 1)]
    float tiempoEntreRecarga;

    private Player player;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject.GetComponentInParent<Player>();
            InvokeRepeating("RecargarSalud", tiempoEntreRecarga, tiempoEntreRecarga);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CancelInvoke();
        }
    }
    private void RecargarSalud()
    {
        player.IncrementarSalud(deltaSalud);
    }
}
