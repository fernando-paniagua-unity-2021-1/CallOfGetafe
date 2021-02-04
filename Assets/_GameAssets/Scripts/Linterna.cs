using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light linterna;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            linterna.enabled = !linterna.enabled;
        }
    }
}
