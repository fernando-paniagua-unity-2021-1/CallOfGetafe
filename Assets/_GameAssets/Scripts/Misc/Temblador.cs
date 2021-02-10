using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temblador : MonoBehaviour
{
    //A medias entre Víctor y Fernando
    private float velocidad;
    private float escalaInicial;
    public float amplitud;
    public float frecuencia;
    private void Start()
    {
        escalaInicial = transform.localScale.x;
    }

    void Update()
    {
        velocidad = Mathf.Sin(Time.time * Mathf.PI / 2 * frecuencia) * amplitud;
        transform.localScale = new Vector3(
            escalaInicial + velocidad,
            escalaInicial + velocidad,
            escalaInicial + velocidad);
    }
}
