using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int saludMaxima;
    [SerializeField]
    private int salud;

    public int GetSalud()
    {
        return salud;
    }
    public int GetSaludMaxima()
    {
        return saludMaxima;
    }
    public void IncrementarSalud(int incrementoSalud)
    {
        salud = salud + incrementoSalud;
        salud = Mathf.Min(salud, saludMaxima);
    }
}
