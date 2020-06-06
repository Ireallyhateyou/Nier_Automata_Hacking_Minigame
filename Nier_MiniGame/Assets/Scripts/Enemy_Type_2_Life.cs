using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Audio;

public class Enemy_Type_2_Life : MonoBehaviour
{
    public int Life = 1;
    public GameObject DeathSound;
    public GameObject Weak_ShockWave;
    public GameObject ExplosionTrail;
    public GameObject ExplosionFullCube;
    public GameObject ExplosionEmptyCube;
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
            Instantiate(Weak_ShockWave , transform.position, transform.rotation);
        }
    }
    private void OnDestroy() {
        Instantiate(DeathSound, transform.position, transform.rotation);
        Instantiate(ExplosionTrail, transform.position, transform.rotation);
        Instantiate(ExplosionFullCube, transform.position, transform.rotation);
        Instantiate(ExplosionEmptyCube, transform.position, transform.rotation);
    }
}
