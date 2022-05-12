﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThirdPersonController : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float gravity = -20f;
    public float jumpHeight = -2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity;

    AIMotor motor;
    public NavMeshAgent agent;
    public float rotateVelocity = 20;

    public enum attackType { Ranged, Meelee };
    public attackType AttackType;

    public GameObject targetEnemy;
    public float attackRange = 50f;
    public float rotateSpeedForAttack;


    Transform target;

    private Animator anim;
    public float lookRadius = 50f;

    Enemy enemy;
    CharacterStat stat;


    private void Start()
    {
        target = GameObject.FindWithTag("NPC").transform;
        anim = GetComponentInChildren<Animator>();
        motor = GetComponent<AIMotor>();
        //enemy = GetComponent<Enemy>();
       // stat = GetComponent<CharacterStat>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //wasd
        anim.SetFloat("Speed", 0f, 0.1f, Time.deltaTime);

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            //arah chara belok
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            anim.SetFloat("Speed", 1f, 0.1f, Time.deltaTime);
        }

        //lari
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = Vector3.forward * speed * 2f * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("Summon", true);
        }
        else 
        {
            anim.SetBool("Summon", false);
            anim.SetBool("PickUp", false);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            anim.SetBool("Jump", true);
        }
        else if (!(Input.GetButtonDown("Jump") && isGrounded))
        {
            anim.SetBool("Jump", false);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        

        
    }
   
    

}