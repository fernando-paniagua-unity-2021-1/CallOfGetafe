using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilador : MonoBehaviour
{
    private float yActual;
    private float yInicial;
    private float yFinal;
    private float porcentaje = 0;

    [Range(0,10)]
    public float distancia;
    [Range(0,50)]
    public float speed;

    private void Start()
    {
        yInicial = transform.position.y;
        yFinal = yInicial + distancia;
    }

    void Update()
    {
        porcentaje = (Mathf.Sin(Time.time * speed) + 1) / 2;
        yActual = Mathf.Lerp(yInicial, yFinal, porcentaje);
        transform.position = new Vector3(transform.position.x, yActual, transform.position.z);
    }
}
