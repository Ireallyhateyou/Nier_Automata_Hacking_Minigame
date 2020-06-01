using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Audio;

public class Enemy_Type_1_Life : MonoBehaviour
{
    public int Life = 3;
    public GameObject DeathSound;
    public GameObject Weak_ShockWave;
    public GameObject ExplosionTrail;
    public GameObject ExplosionCube;
    public AudioSource HitSound;


    void Update()
    {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player_Projectile")
        {
            Life -= 1;
            HitSound.Play();
            Instantiate(Weak_ShockWave , transform.position, transform.rotation);
        }
    }
    private void OnDestroy() {
        Instantiate(DeathSound, transform.position, transform.rotation);
        Instantiate(ExplosionTrail, transform.position, transform.rotation);
        Instantiate(ExplosionCube, transform.position, transform.rotation);
    }
}
