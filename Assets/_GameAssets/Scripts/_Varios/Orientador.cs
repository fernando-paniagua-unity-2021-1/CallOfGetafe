using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientador : MonoBehaviour
{
    private Transform target;
    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        if (target.gameObject.GetComponent<Player>() == null)
        {
            Debug.LogError("HAY UN INTRUSO QUE SE ESTÁ HACIENDO PASAR POR PLAYER:" + target.gameObject.name );
        }
    }

    void Update()
    {
        transform.LookAt(target);
    }
}
