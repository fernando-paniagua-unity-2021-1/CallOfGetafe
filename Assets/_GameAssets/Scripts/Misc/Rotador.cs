using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    [Range(-200,200)]
    public float speed;
    private void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
