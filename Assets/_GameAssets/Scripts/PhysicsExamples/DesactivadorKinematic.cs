using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivadorKinematic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }

}
