using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefabBoss;
    public Transform posicionBoss;
    private int numeroDeEnemigosVivos;
    public void AddEnemigo(){
        numeroDeEnemigosVivos++;
    }
    public void QuitarEnemigo(){
        numeroDeEnemigosVivos--;
        if (numeroDeEnemigosVivos==0){
            Instantiate(prefabBoss, posicionBoss);
        }
    }

}
