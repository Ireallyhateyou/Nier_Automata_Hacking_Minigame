using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weak_ShockWave_Behavior : MonoBehaviour
{
    void Start()
    {
        if (name != "Enemy_death_Shockwave")
        {
            Destroy(gameObject, 3);
        }
    }
}
