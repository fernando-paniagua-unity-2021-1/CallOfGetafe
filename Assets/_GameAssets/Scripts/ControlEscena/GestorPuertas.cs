using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorPuertas : MonoBehaviour
{
    //public Animator miAnimator;
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    miAnimator.enabled = true;
        //}
        if (Input.GetKey(KeyCode.O))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
    }
}
