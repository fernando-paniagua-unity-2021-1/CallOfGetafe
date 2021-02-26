using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoItem : MonoBehaviour
{
    [SerializeField]
    private int municion;

    public int GetMunicion()
    {
        return municion;
    }
}
