using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaludPositivaManager : MonoBehaviour
{
    [SerializeField]
    Player player;
    [SerializeField]
    Image imagenVidaPositiva;

    private int saludMaxima;
    private void Start()
    {
        saludMaxima = player.GetSaludMaxima();
    }

    void Update()
    {
        int salud = player.GetSalud();
        imagenVidaPositiva.fillAmount = (float)salud / (float)saludMaxima;
    }
}
