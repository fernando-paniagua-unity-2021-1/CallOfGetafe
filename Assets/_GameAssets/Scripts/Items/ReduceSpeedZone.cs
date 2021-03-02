using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ReduceSpeedZone : MonoBehaviour
{
    private Player player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<FirstPersonController>().m_WalkSpeed *= 0.5f;
            other.gameObject.GetComponent<FirstPersonController>().m_RunSpeed *= 0.5f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<FirstPersonController>().m_WalkSpeed *= 2;
            other.gameObject.GetComponent<FirstPersonController>().m_RunSpeed *= 2;
        }
    }
    
}
