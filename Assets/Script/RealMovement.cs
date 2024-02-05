using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RealMovement : MonoBehaviour
{
    public float score = 0;
    public float speed;
    public GameObject player;
    public GameObject cam;
    
    public float playerHeight;
    public LayerMask WhatGround;
    public LayerMask WhatGround2;
    bool grounded;
    bool cubed;
    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump = true;
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    private void Jump(){
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        if(grounded||cubed) rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        else rb.AddForce(transform.up * jumpForce * airMultiplier, ForceMode.Impulse);
    }
    private void JumpReset(){
        readyToJump = true;
    }
    void OnTriggerStay(Collider other){
        if(other.tag=="blocks") transform.Translate(transform.up * Time.deltaTime * 5.4f * other.GetComponent<CubeUp>().speed * (1+System.MathF.Abs(score/50)), 0);
        return;
    }
    void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight*0.5f+0.2f, WhatGround);
        cubed = Physics.Raycast(transform.position, Vector3.down, playerHeight*0.5f+0.2f, WhatGround2);
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        if(Input.GetKey(KeyCode.Space)&&readyToJump&&(grounded||cubed)){
            readyToJump = false;
            Jump();
            Invoke("JumpReset", jumpCooldown);
        }
        if(grounded&&score>0){
            score-=0.01f*Time.deltaTime*speed;
        }
        Vector3 cameraForward = Camera.main.transform.forward;
        Vector3 cameraRight = Camera.main.transform.right;
        cameraForward.y = 0f;
        cameraRight.y = 0f;
        
        
        Vector3 moveDirection = cameraForward * inputDirection.z + cameraRight * inputDirection.x;
        if(grounded||cubed) transform.Translate(moveDirection * speed * Time.deltaTime);
        else transform.Translate(airMultiplier * moveDirection * speed * Time.deltaTime);
    }
}
