using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientadorGuay : Orientador
{
    public Transform baseTransform;
    public float speed;
    private Transform targetTransform;
    
    private void Awake()
    {
        targetTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        //Base
        //Vector3 targetPositionBase = new Vector3(targetTransform.position.y, baseTransform.position.y, targetTransform.position.z);
        //Vector3 targetDirectionBase = targetPositionBase - transform.position;
        //Vector3 directionBase = Vector3.RotateTowards(transform.forward, targetDirectionBase, speed, 0);
        //baseTransform.rotation = Quaternion.LookRotation(directionBase);


        //Canyon
        //Vector3 targetPositionCanyon = new Vector3(transform.position.x, targetTransform.position.y, targetTransform.position.z);
        //Vector3 targetDirectionCanyon = targetPositionCanyon - transform.position;
        //Vector3 directionCanyon = Vector3.RotateTowards(transform.forward, targetDirectionCanyon, speed, 0);
        //transform.rotation = Quaternion.LookRotation(directionCanyon);

        //Canyon
        Vector3 targetDirection = targetTransform.position - transform.position;
        Vector3 direction = Vector3.RotateTowards(transform.forward, targetDirection, speed, 0);
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
