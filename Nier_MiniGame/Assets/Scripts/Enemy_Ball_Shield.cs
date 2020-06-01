using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ball_Shield : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject Target;
    void Update()
    {
        if (name != "Enemy_Shield")
        FollowTarget();
        Enemy = GameObject.FindGameObjectsWithTag("Enemy_Type_2");
        if (Enemy.Length == 1)
        {
            AutoDestruct();
        }
    }
    void AutoDestruct()
    {
        Destroy(gameObject);
    }
    void FollowTarget()
    {
        transform.position = Target.transform.position;
    }

}
