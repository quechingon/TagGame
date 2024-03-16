using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //The "Header" things are used to create titles in the unity ui for assigning variables
    [Header("Movement")]
    private float moveSpeed;
    public float walkSpeed;
    public float sprintSpeed;

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    public float crouchSpeed;
    public float crouchYScale;
    private float startYScale;

    private float desiredMoveSpeed;
    private float lastDesiredMoveSpeed;
    public float slideSpeed;
    public bool sliding;

    public float wallrunSpeed;
    public bool wallrunning;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode sprintKey = KeyCode.LeftShift;
    public KeyCode crouchKey = KeyCode.C;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    [Header("Slope")]
    public float maxSlopeAngle;
    private RaycastHit slopeHit;
    private bool exitingSlope;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    public MovementState state;

    public enum MovementState
    {
        walking,
        sprinting,
        wallrunning,
        crouching,
        sliding,
        air
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; //Stop player from falling over
        readyToJump = true;

        startYScale = transform.localScale.y;
    }

    private void Update()
    {
        //Check for ground
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.1f, whatIsGround);

        MyInput();
        SpeedControl();
        StateHandler();
        //drag handled here
        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0; //drag in air here, 0 for now
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //jump
        if (Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }

        //crouch
        if (Input.GetKeyDown(crouchKey))
        {
            transform.localScale = new Vector3(transform.localScale.x, crouchYScale, transform.localScale.z);
            rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);
        }
        //uncrouch
        if (Input.GetKeyUp(crouchKey))
        {
            transform.localScale = new Vector3(transform.localScale.x, startYScale, transform.localScale.z);
        }

    }

    private void MovePlayer()
    {
        //calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        //On ground
        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else if (!grounded) //In air
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }

        //for slopes
        else if (OnSlope() && !exitingSlope)
        {
            rb.AddForce(GetSlopeMoveDirection(moveDirection) * moveSpeed * 20f, ForceMode.Force);
            rb.AddForce(GetSlopeMoveDirection(moveDirection) * moveSpeed * 20f, ForceMode.Force);

            if (rb.velocity.y > 0)
            {
                rb.AddForce(Vector3.down * 80f, ForceMode.Force);
            }

            //we COULD turn gravity off while on slopes. Should we? No clue. Here's the code for it anyways.
            //rb.useGravity = !OnSlope();
        }
    }

    public void StateHandler()
    {
        //Script for changing what the player can do based on whether theyre in air/on ground/etc


        //for wallrunning

        if(wallrunning)
        {
            state = MovementState.wallrunning;
            desiredMoveSpeed = wallrunSpeed;
        }

        //for sliding
        if (sliding)
        {
            state = MovementState.sliding;

            if (OnSlope() && rb.velocity.y < 0.1f)
            {
                desiredMoveSpeed = slideSpeed;
            }
            else { desiredMoveSpeed = sprintSpeed; }
        }

        //for sprinting
        if (grounded && Input.GetKey(sprintKey))
        {
            state = MovementState.sprinting;
            desiredMoveSpeed = sprintSpeed;
        }



        //for walking
        else if (grounded)
        {
            state = MovementState.walking;
            desiredMoveSpeed = walkSpeed;
        }

        //for crouching
        
        else if (Input.GetKey(crouchKey))
        {
            state = MovementState.crouching;
            desiredMoveSpeed = crouchSpeed;
        }


        //else
        else 
        {
            state = MovementState.air;
        }

        //check for sudden big change in desired movespeed (dms)
        if(Mathf.Abs(desiredMoveSpeed - lastDesiredMoveSpeed) > 5f && moveSpeed != 0)
        {
            StopAllCoroutines();
            StartCoroutine(SmoothMovespeedLerp());
        }
        else
        {
            moveSpeed = desiredMoveSpeed;
        }
        
        lastDesiredMoveSpeed = desiredMoveSpeed;
    }

    private  IEnumerator SmoothMovespeedLerp()
    {
        //lerp movespeed to desired value. this is out momentum.
        float time = 0;
        float difference = Mathf.Abs(desiredMoveSpeed - moveSpeed);
        float startValue = moveSpeed;

        while (time < difference)
        {
            moveSpeed = Mathf.Lerp(startValue, desiredMoveSpeed, time/difference);
            time += Time.deltaTime;
            yield return null;
        }

        moveSpeed = desiredMoveSpeed;
    }

    private void SpeedControl()
    {
        

        //fix slope speed
        if(OnSlope() && !exitingSlope)
        {
            if(rb.velocity.magnitude > moveSpeed)
            {
                rb.velocity = rb.velocity.normalized * moveSpeed;
            }
        }
        else
        {
            Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

            //Limit velocity here
            if (flatVel.magnitude > moveSpeed)
            {
                Vector3 limitedVel = flatVel.normalized * moveSpeed;
                rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
            }
        }

                

        

        
    }

    private void Jump()
    {
        exitingSlope = true;

        
        //Reset y vel before the jump so we have the same jump force each time, could be changed

        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        readyToJump = true;
        exitingSlope = false;
    }


    public bool OnSlope()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out slopeHit, playerHeight * 0.5f + 0.3f))
        {
            float angle = Vector3.Angle(Vector3.up, slopeHit.normal);
            return angle < maxSlopeAngle && angle != 0;
        }
        return false;
    }

    public Vector3 GetSlopeMoveDirection(Vector3 direction)
    {
        return Vector3.ProjectOnPlane(direction, slopeHit.normal).normalized;
    }

}
