using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Assets.Scripts;
using UnityEngine;

public class PlayerController104Force : MonoBehaviour
{
    public Vector3 force = new Vector3(0, 20, 0);
    private Animator _animator;
    private Rigidbody _rb;

    public bool isJumping;
    public bool isGrounded;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            isJumping = true;
            isGrounded = false;

            if (isJumping)
            {
                _animator.SetBool("isJumping", true);
            }
        }
        else
        {
            isJumping = false;
        }

    }

    void FixedUpdate()
    {
        if (isJumping)
        {
            _rb.AddForce(force, ForceMode.Force);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (!isGrounded)
        {
            if (other.CompareTag("Ground"))
            {
                isGrounded = true;
                _animator.SetBool("isJumping", false);
            }
        }
        
    }
    
}

