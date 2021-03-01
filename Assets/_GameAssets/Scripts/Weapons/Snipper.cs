using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snipper : Weapon
{
    [Header("Especificos de Snipper")]
    [SerializeField]
    int danyo;
    [SerializeField]
    GameObject imageScope;
    [SerializeField]
    Renderer armaRenderer;
    [SerializeField]
    Camera mainCamera;
    [SerializeField]
    float fovZoomIn;
    private float fovZoomOut;

    protected void Awake()
    {
        base.Awake();
        fovZoomOut = mainCamera.fieldOfView;
    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            imageScope.SetActive(true);
            armaRenderer.enabled = false;
            mainCamera.fieldOfView = fovZoomIn;
        }
        else
        {
            RestaurarEstado();
        }
    }
    public override void Disparar()
    {
        if (municion > 0)
        {
            PlaySonidoDisparo();
            Ray rayo = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
            //Debug.DrawRay(mainCamera.transform.position, mainCamera.transform.forward, Color.red, 5);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayo, out hitInfo))
            {
                if (hitInfo.transform.gameObject.CompareTag("Enemigo"))
                {
                    //Hemos dado a un enemigo
                    Enemigo enemigo = hitInfo.transform.gameObject.GetComponentInParent<Enemigo>();
                    enemigo.QuitarVida(
                        danyo,
                        new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z),
                        hitInfo.normal,
                        enemigo.transform);
                }
            }
            municion--;
        }
        else
        {
            PlaySonidoGatillazo();
        }
    }

    public void RestaurarEstado()
    {
        imageScope.SetActive(false);
        armaRenderer.enabled = true;
        mainCamera.fieldOfView = fovZoomOut;
    }
}