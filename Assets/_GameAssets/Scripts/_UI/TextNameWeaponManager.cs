using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextNameWeaponManager : MonoBehaviour
{
    public Text nombreArma;
    public WeaponManager wm;
    private void Update()
    {
        nombreArma.text = wm.GetCurrentWeaponName();
    }
}
