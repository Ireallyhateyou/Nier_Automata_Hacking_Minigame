using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Behavior : MonoBehaviour
{
    public float Time_Before_Destruction;
    public GameObject Projectile_Surface_Hit;
    private void Start() {
        gameObject.transform.Rotate(0, 0, 45);
    }
    void FixedUpdate()
    {
        Autodestruct();
    }
    private void OnTriggerEnter(Collider collider)
    {
        if ( collider.tag == "Orange_Enemy_Projectile")
        {
            Destroy(gameObject);
        }
        if ( collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collider.tag == "Enemy_Shield")
        {
            Destroy(gameObject);
        }
        if (collider.tag == "Stage_White_Cube")
        {
            Instantiate(Projectile_Surface_Hit, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    public void Autodestruct()
    {
        if (gameObject.name != "Simple_Projectile")
        {
          Destroy(gameObject, Time_Before_Destruction);  
        }
    }
}   