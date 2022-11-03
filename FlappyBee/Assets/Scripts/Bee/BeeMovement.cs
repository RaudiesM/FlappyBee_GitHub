using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private float pushForce;
    private Vector3 flyingForce;
    private Rigidbody2D beeBody;
    private bool isFlying;
    private bool isFalling;
    public bool gameStart { get; private set; }



    private void Start()
    {
        beeBody = GetComponent<Rigidbody2D>();
        flyingForce = new Vector2(0, pushForce);
    }

    
    private void Update()
    {
        CheckInput();
        CheckFall();
        CheckGameStart();
    }


    private void FixedUpdate()
    {
        HandleFlying();
        //work in Progress
        //HandleRotation();  

    }

    #region Check-Methods
    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFlying = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isFlying = false;
        }
    }

    private void CheckFall()
    {
        if (beeBody.velocity.y > 0)
        {
            isFalling = false;
        }
        else
        {
            isFalling = true;
        }
    }
    private void CheckGameStart()
    {
        if(Input.GetKeyDown(KeyCode.Space) && gameStart == false)
        {
            gameStart = true;
        }
    }

    #endregion

    #region Handle-Methods

    private void HandleFlying()
    {
        if (isFlying)
        {
            beeBody.AddForce(flyingForce, ForceMode2D.Force);
        }
    }

    private void HandleRotation()
    {
        if(isFalling)
        {
            if(transform.rotation.z >= -0.5663706f)
            {
                transform.Rotate(new Vector3(0, 0, -12 * Time.deltaTime));
            }
        }
        else
        {
            if (transform.rotation.z <= 0.5663706f)
            {
                transform.Rotate(new Vector3(0, 0, 12 * Time.deltaTime));
            }
        }
    }
    #endregion
}
