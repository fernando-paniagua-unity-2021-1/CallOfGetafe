using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicioDesperador : MonoBehaviour
{
    public Rigidbody rb;
    
    void Update()
    {
        if (rb.IsSleeping())
        {
            rb.WakeUp();
        }
    }
}
