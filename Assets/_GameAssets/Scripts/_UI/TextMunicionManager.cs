using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMunicionManager : MonoBehaviour
{
    public Text textoMunicion; 
    public WeaponManager wm;
    private void Update()
    {
        textoMunicion.text = wm.GetCurrentAmmo() + "/" + wm.GetTotalAmmo();
        //textoMunicion.text = wm.GetCurrentAmmo().ToString() + "/" + wm.GetTotalAmmo().ToString();
    }
}
