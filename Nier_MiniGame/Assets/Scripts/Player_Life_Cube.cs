using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life_Cube : MonoBehaviour
{
    public Animator HitAnimation;
    private bool NotTooLong = false ;
    private float timestamp;
    public float Time_Between_Hits = .01f;
    private int Life;
    void Start()
    {
        HitAnimation = gameObject.GetComponent<Animator>();
        Life = Player_Life.Life;
    }

    // Update is called once per frame
    void Update()
    {
        if (Life != Player_Life.Life)
        {
            Life = Player_Life.Life;
            HitAnimation.SetTrigger("IsHit");
            timestamp = Time.time + Time_Between_Hits;
            HitAnimation.SetTrigger("StopHittingOnME");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
        }

        if (Time.time >= timestamp)
        {
            
   
        }

        
    }
}
