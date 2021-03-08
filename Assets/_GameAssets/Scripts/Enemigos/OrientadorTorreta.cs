using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientadorTorreta : Orientador
{
    public Transform transformBaseRotacionHorizontal;
    public Transform transformContenedorCanyon;
    public float speed;
    private Transform transformTarget;

    private void Awake()
    {
        //Obtiene la referencia al player
        transformTarget = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        //Movimiento horizontal
        /*
        Obtiene el target para el movimiento horizontal con las coordenadas 'x' y 'z' del player 
        y la 'y' de la base de la torreta que no rote en vertical
        */
        Vector3 targetHorizontalPosition = new Vector3(
            transformTarget.position.x,
            transformBaseRotacionHorizontal.position.y,
            transformTarget.position.z);
        //Obtiene el vector de dirección que va desde la base hasta el target anterior
        Vector3 horizontalDirection = targetHorizontalPosition - transformBaseRotacionHorizontal.position;
        /*
        Obtiene la rotación de la base hacia el target (recordamos que 
        la 'y' del target es la de la base, no la del player)
        */
        Vector3 newHorizontalDirection = Vector3.RotateTowards(
            transformBaseRotacionHorizontal.forward,
            horizontalDirection, speed, 0);
        //Realiza la rotación
        transformBaseRotacionHorizontal.rotation = Quaternion.LookRotation(newHorizontalDirection);
        //Obtiene los grados de  diferencia entre el forward de la base y la direccion anterior
        float horizontalDifferencAngle = Vector3.Angle(transformBaseRotacionHorizontal.forward, horizontalDirection);
        //Movimiento vertical, sólo si está alineado horizontalmente
        if (Mathf.Abs(horizontalDifferencAngle) < 1f)
        {
            //Obtiene el vector de dirección que va desde el cañón hasta el player
            Vector3 verticalDirection = transformTarget.position - transformContenedorCanyon.position;
            //Obtiene la rotación del cañón hacia el player
            Vector3 newVerticalDirection = Vector3.RotateTowards(
                transformContenedorCanyon.forward,
                verticalDirection, speed, 0);
            //Realiza la rotación
            transformContenedorCanyon.rotation = Quaternion.LookRotation(newVerticalDirection);
        }
    }
}
