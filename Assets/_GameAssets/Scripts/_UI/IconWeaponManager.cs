using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconWeaponManager : MonoBehaviour
{
    public Image imageIconWeapon;
    public WeaponManager wm;
    private void Update()
    {
        imageIconWeapon.sprite = wm.GetCurrentWeaponIconSprite();
    }
}

