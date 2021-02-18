using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public float speed;
    public Rigidbody miRigidBody;
    private float x, z;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        miRigidBody.velocity = 
            new Vector3(x * speed, 
            miRigidBody.velocity.y, 
            z * speed);
    }
}
