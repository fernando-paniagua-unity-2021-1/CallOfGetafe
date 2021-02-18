using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModificadorMaterial : MonoBehaviour
{
    public MeshRenderer mr;
    float azul;
    float glossiness;
    private void Start()
    {
        //Sobre la copia del objeto que ejecuta el script
        azul = mr.material.color.b;
        glossiness = mr.material.GetFloat("_Glossiness");
        //Sobre todos los objetos que utilizan el mismo material
        //azul = mr.sharedMaterial.color.b;
        //glossiness = mr.sharedMaterial.GetFloat("_Glossiness");

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            azul += Time.deltaTime;
            azul = Mathf.Min(azul, 1);
            glossiness += Time.deltaTime * 0.5f;
            glossiness = Mathf.Min(glossiness, 1);
            //Sobre la copia
            mr.material.SetColor("_Color", new Color(mr.material.color.r, mr.material.color.g, azul));
            mr.material.SetFloat("_Glossiness", glossiness);
            //Sobre el material compartido
            //mr.sharedMaterial.SetColor("_Color", new Color(mr.sharedMaterial.color.r, mr.sharedMaterial.color.g, azul));
            //mr.sharedMaterial.SetFloat("_Glossiness", glossiness);
        }
    }
}
