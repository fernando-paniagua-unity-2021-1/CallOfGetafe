using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    [Range(0,0.1f)]
    public float amplitude;
    [Range(0, 1)]
    public float frecuency;

    private int direction = 1;

    private void Start()
    {
        InvokeRepeating("Mover", 0, frecuency);
    }
    private void Mover()
    {
        transform.Translate(Vector3.up * amplitude * direction);
        direction *= -1;
    }
}
