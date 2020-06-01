using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purple_Enemy_Projectile_Behaviour : MonoBehaviour
{
    public float Time_Before_Destruction;
    public GameObject Projectile_Surface_Hit;
    private void Start() {
        if (gameObject.name != "Purple_Enemy_Projectile")
        {
            Autodestruct();
        }
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collider.tag == "Stage_White_Cube")
        {
            Debug.Log("purple");
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
