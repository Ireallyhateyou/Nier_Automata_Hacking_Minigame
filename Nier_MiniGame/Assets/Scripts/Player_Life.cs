using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life : MonoBehaviour
{
    public static int Life = 3;
    private float timestamp;
    public float Time_Between_Hits = 1f;


    void Update()
    {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider collider) {        
        if ((collider.tag == "Orange_Enemy_Projectile" | collider.tag == "Purple_Enemy_Projectile") & Time.time >= timestamp)
        {
            Life -= 1;
            timestamp = Time.time + Time_Between_Hits;
        }
    }
}
