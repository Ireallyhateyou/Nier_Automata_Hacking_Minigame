using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Death_Sound : MonoBehaviour
{
  void Start()
  {
   if (gameObject.name != "Enemy_Death_Sound")
    {
      Destroy(gameObject, 3);  
    }      
  }
}
