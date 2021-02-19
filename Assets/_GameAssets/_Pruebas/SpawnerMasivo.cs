using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMasivo : MonoBehaviour
{
    public float fuerza;
    public float numeroObjetos;
    public GameObject prefab;

    private void Start()
    {
        SpawnObjectsRandomDirection();
    }

    private void SpawnObjectsRandomDirection()
    {
        for (int i = 0; i < numeroObjetos; i++)
        {
            GameObject cubo = Instantiate(prefab, transform.position, transform.rotation);
            cubo.GetComponent<Rigidbody>().AddForce(
                new Vector3(
                    Random.Range(-fuerza, fuerza),
                    fuerza,
                    Random.Range(-fuerza, fuerza)));
        }
    }
}
