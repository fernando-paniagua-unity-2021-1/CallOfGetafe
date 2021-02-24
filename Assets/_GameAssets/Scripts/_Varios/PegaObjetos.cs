using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegaObjetos : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Entrando en colisión");
        transform.SetParent(collision.gameObject.transform);

    }
    private void OnCollisionStay(Collision collision)
    {
        print("Durante la colisión");
    }
    private void OnCollisionExit(Collision collision)
    {
        print("Saliendo de colisión");
        transform.SetParent(null);
    }
}
