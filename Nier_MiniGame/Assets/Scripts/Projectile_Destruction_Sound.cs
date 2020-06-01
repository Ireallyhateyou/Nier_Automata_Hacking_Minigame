using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Destruction_Sound : MonoBehaviour
{
    void Start()
  {
   if (gameObject.name != "Projectile_Surface_Hit")
    {
        Destroy(gameObject, 1);  
    }      
  }
}
