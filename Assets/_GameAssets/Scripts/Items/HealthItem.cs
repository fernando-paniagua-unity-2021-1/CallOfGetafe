using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    [SerializeField]
    private int salud;

    public int GetSalud()
    {
        return salud;
    }
}
