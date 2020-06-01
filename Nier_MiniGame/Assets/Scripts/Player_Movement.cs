using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] public InputMaster Controls;
    
    private Rigidbody rb;
    private Vector2 MoveAxis;
    private Vector2 RotateAxis;
    public float Moving_Speed;
    private void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Awake() {
        Controls = new InputMaster();

        Controls.Player.Movement.performed += ctx => MoveAxis = ctx.ReadValue<Vector2>();
        Controls.Player.Movement.canceled += ctx => MoveAxis = Vector2.zero;

        Controls.Player.Rotate.performed += ctx => RotateAxis = ctx.ReadValue<Vector2>();
        // Find a way to cancel it you lazy piece of fuck
    }
    private void FixedUpdate() {
        Move();
        Rotate();
    }
    void Move()
    {
        rb.AddForce(0, 0, MoveAxis.y * Time.deltaTime * Moving_Speed, ForceMode.VelocityChange);  
        rb.AddForce(MoveAxis.x  * Time.deltaTime * Moving_Speed, 0, 0, ForceMode.VelocityChange);
    }
    void Rotate()
    {

         rb.transform.eulerAngles = new Vector3( 0, Mathf.Atan2( RotateAxis.x, RotateAxis.y) * 180 / Mathf.PI, 0 );   

    }
    private void OnEnable() {
        Controls.Enable();
    }
    private void OnDisable() {
        Controls.Disable();
    }
}
