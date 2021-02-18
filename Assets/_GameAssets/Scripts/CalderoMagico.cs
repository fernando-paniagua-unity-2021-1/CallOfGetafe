using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalderoMagico : MonoBehaviour
{
    public ParticleSystem ps;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ps.Play();
        }
    }
}
