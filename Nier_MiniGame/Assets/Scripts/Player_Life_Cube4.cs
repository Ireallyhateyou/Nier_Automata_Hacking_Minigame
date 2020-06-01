using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life_Cube4 : MonoBehaviour
{
    void Update()
    {
        if (Player_Life.Life == 2)
        {
            Destroy(gameObject);
        }
    }
}
