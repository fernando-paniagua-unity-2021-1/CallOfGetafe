using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodHealth : MonoBehaviour
{
    [SerializeField]
    Image imagenSangre;
    [SerializeField]
    Player player;

    private int saludMaxima;
    void Start()
    {
        saludMaxima = player.GetSaludMaxima();
    }

    // Update is called once per frame
    void Update()
    {
        int salud = player.GetSalud();
        imagenSangre.color = new
            Color(1, 1, 1, 1 - ((float)salud / (float)saludMaxima));
    }
}
