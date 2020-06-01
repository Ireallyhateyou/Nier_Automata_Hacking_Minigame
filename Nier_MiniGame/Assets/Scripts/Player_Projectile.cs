using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player_Projectile : MonoBehaviour
{
    [SerializeField] public InputMaster Controls;
    public Rigidbody RightProjectile;
    public float RightProjectileSpeed = 300;
    private bool RightBumperpressed;
    public float Time_Between_Shots = 0.3333f;
    private float timestamp;
    public AudioClip shootsound;
    public AudioSource main;
    private void Awake() {
        Controls = new InputMaster();

        Controls.Player.Right_Shoot.performed += ctx => RightBumper();
        Controls.Player.Right_Shoot.canceled += ctx => RightBumperStop();
    }
    void Update() 
    {
        if (RightBumperpressed)
        {
            RightShoot();
        }    
    }
    
    void RightShoot()
    {
        if (Time.time >= timestamp)
        {
            Rigidbody Projectile = Instantiate(RightProjectile, transform.position, transform.rotation);
            Projectile.velocity = transform.forward * RightProjectileSpeed;
            main.PlayOneShot(shootsound, 1);
            timestamp = Time.time + Time_Between_Shots;
        }
    }
    void RightBumper()
    {
        RightBumperpressed = true;
    }
    void RightBumperStop()
    {
        RightBumperpressed = false;
    }
    private void OnEnable() {
        Controls.Enable();
    }
    private void OnDisable() {
        Controls.Disable();
    }
}