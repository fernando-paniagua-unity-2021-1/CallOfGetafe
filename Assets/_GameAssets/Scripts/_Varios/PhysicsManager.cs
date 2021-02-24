using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Colision:" + transform.gameObject.name);
    }
}
