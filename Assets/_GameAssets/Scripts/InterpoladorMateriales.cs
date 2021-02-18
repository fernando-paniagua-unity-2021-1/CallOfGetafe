using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpoladorMateriales : MonoBehaviour
{
    public Renderer renderer;
    public Material m1;
    public Material m2;

    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            float porcentaje = Mathf.PingPong(Time.time, 0.5f) / 0.5f;
            renderer.material.Lerp(m1, m2, porcentaje);
        }
    }
}
