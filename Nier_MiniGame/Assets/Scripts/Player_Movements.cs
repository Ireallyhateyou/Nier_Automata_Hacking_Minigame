using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 50f;
    public float sidewayforce = 50f;
    public float verticalRotation;
    public float mouseSensitivity = 0.5f;
    public Quaternion final;
    public float rotationspeed;
    public Vector3 reset;

    void FixedUpdate()
    {
        if (Input.GetKey("z"))
        {
            rb.AddRelativeForce(0, 0, forwardforce  * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddRelativeForce(sidewayforce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if (Input.GetKey("q"))
        {
            rb.AddRelativeForce(-sidewayforce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddRelativeForce(0, 0, -forwardforce  * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("r"))
        {
            transform.position = reset;
        }
        verticalRotation -= Input.GetAxis("Mouse X") * mouseSensitivity;
   
        transform.rotation = Quaternion.Euler(0, verticalRotation, 0);

        
    

        
    }
}
/*float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f); */
        /*if (Input.GetMouseButton(0)) {
              if (Input.mousePosition.x > Screen.width / 2) desiredRot -= rotSpeed * Time.deltaTime;
              else desiredRot += rotSpeed * Time.deltaTime;
          }
 
         var desiredRotQ = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, desiredRot);
         transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotQ, Time.deltaTime * damping);*/
         
         
         /*verticalRotation -= Input.GetAxis("Mouse X") * -mouseSensitivity;
        final = Quaternion.Euler(transform.rotation.x, verticalRotation, transform.rotation.z);  
        transform.rotation = Quaternion.Lerp(transform.rotation, final, Time.deltaTime * rotationspeed);*/