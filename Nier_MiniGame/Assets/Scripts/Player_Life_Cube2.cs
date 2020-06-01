using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life_Cube2 : MonoBehaviour
{
    void Update()
    {
        if (Player_Life.Life == 1)
        {
            Destroy(gameObject);
        }
    }
}
