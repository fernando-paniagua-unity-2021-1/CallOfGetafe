using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorOscilador : MonoBehaviour
{
    private float velocidad;
    private float yInicial;
    public float amplitud;
    public float frecuencia;

    private void Start()
    {
        yInicial = transform.position.y;
    }

    void Update()
    {
        velocidad = Mathf.Sin(Time.time * Mathf.PI / 2 * frecuencia) * amplitud;
        transform.position = new Vector3(transform.position.x, yInicial + velocidad, transform.position.z);
    }

}
