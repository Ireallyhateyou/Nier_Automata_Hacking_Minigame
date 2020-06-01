using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Death_Explosion_Trail_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (name != "Enemy_Death_Explosion_Trail")
        {
            Destroy(gameObject, 3);
        }
    }
}
