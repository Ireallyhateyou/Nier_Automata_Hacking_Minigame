using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_hit_Wall_Behavior : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1);
    }
}
