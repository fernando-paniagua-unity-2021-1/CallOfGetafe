using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Esta clase debería llamarse SliderHealthManager
public class TextHealthManager : MonoBehaviour
{
    public Slider sliderSalud;
    public Player player;
    private float saludMaxima;
    private void Start()
    {
        saludMaxima = player.GetSaludMaxima();
    }
    private void Update()
    {
        sliderSalud.value = (float)player.GetSalud() / saludMaxima;
    }
}
