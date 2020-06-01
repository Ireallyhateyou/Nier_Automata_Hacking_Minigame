using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Black_hit_Fade : MonoBehaviour
{
    public Animator HitAnimation;
    private bool NotTooLong = false ;
    private float timestamp;
    public float Time_Between_Hits = .01f;
    void Start()
    {
        HitAnimation = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            HitAnimation.SetTrigger("IsHit");
            timestamp = Time.time + Time_Between_Hits;
            HitAnimation.SetTrigger("StopHittingOnME");
        }

        if (Time.time >= timestamp)
        {
            
   
        }

        
    }
}
