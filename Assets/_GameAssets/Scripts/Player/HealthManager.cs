using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SaludItem"))
        {
            player.IncrementarSalud(
                other.gameObject.
                GetComponentInParent<HealthItem>().
                GetSalud());
            Destroy(other.gameObject);
        }
    }
}
