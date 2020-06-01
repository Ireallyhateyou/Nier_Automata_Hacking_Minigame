using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Following_Player_Behavior : MonoBehaviour
{
    public Rigidbody rb;
    public Transform Target;
    private Vector3 Direction;
    private Vector3 TargetXZ;
    private Vector3 RotateAmount;
    public float RotationSpeed;
    public float Speed;
    private Quaternion Modified_Rotation;
    private bool TouchingPlayer = false;
    public GameObject[] Enemy;
    private void Start() {
        Modified_Rotation = gameObject.transform.rotation;
    }
    void Update()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy_Type_2");
        if (gameObject.name != "Enemy_Type_1" & TouchingPlayer == false &  Enemy.Length == 1)
        {
          FollowTarget();
        }else
        {
            transform.LookAt(Target);
        }
    }

    void FollowTarget()
    {
        TargetXZ = new Vector3(Target.position.x, gameObject.transform.position.y, Target.position.z);
        Direction = TargetXZ - rb.position;
        Direction.Normalize();
        RotateAmount = Vector3.Cross(transform.forward, Direction);
        RotateAmount = new Vector3(0, RotateAmount.y, 0);
        rb.angularVelocity = RotateAmount * RotationSpeed;
        rb.velocity= transform.forward * Speed;
    }
    private void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Stop_Area_For_Enemies")
        {
            TouchingPlayer = true;
            Debug.Log("touching");
        }
    }
    private void OnTriggerExit(Collider collider) {
        if (collider.tag == "Stop_Area_For_Enemies")
        {
            TouchingPlayer = false;
            Debug.Log("not touching");
        }
    }
}
