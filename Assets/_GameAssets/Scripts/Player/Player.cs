using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int saludMaxima;
    [SerializeField]
    private int salud;
    [SerializeField]
    private GameObject gameOverGroup;
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
        if (salud<=0){
            Time.timeScale=0;
            Cursor.visible = true;//Hace visible el cursor
            Cursor.lockState=CursorLockMode.None;//Libera el cursor
            GetComponent<FirstPersonController>().enabled=false;
            GetComponent<WeaponManager>().enabled=false;
            gameOverGroup.SetActive(true);
        }
    }
}