using UnityEngine;
public class CharacterControllerDemo : MonoBehaviour
{
    float y;
    public CharacterController characterController;
    void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.X)){
            y+=0.01f;
        } else if (Input.GetKey(KeyCode.Z)){
            y-=0.01f;
        } else {
            y=0;
        }
        characterController.Move(new Vector3(x,y,z));
        transform.Rotate(0, x, 0);
        Vector3 posicionCamara = GetComponentInChildren<Camera>().transform.position;
        Vector3 forwardCamara = GetComponentInChildren<Camera>().transform.forward;
    }
}