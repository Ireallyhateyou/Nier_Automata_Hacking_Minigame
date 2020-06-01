using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange_Enemy_Projectile_Behaviour : MonoBehaviour
{
    public float Time_Before_Destruction;
    public GameObject Projectile_Surface_Hit;
    private void Start() {
        
        if (gameObject.name != "Orange_Enemy_Projectile")
        {
            Autodestruct();
        }
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player_Projectile")
        {
            Destroy(gameObject);
        }

        if (collider.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collider.tag == "Stage_White_Cube")
        {
            Debug.Log("orange");
            Instantiate(Projectile_Surface_Hit, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public void Autodestruct()
    {
        Destroy(gameObject, Time_Before_Destruction);  
    }
}
