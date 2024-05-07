using Alteruna.Scoreboard;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class P_StateManager : MonoBehaviour
{
    //private Alteruna.Avatar _avatar;
    //I'm using "_" for every variable that's declared in the class and not using it for the ones declared in methods. Should make it easier to see which one belongs where at a glance. Please follow this convention to the best of your abilities.
    PlayerInput _playerInput;


    CapsuleCollider _capsuleCollider;
    Bounds _bounds;

    int _maxBounces = 5;
    float _skindWidth = 0.05f;

    LayerMask whatIsGround;
     



    public float _mouseSens;
    public float _maxSlopeAngle;
    public float _softCap;
    public float _sprintResistance;
    public float _slideResistance;

    int _isWalkingHash;
    int _isSprintingHash;
    int _isFallingHash;
    int _isWallRunningHash;
    int _isSlidingHash;
    int _isClimbingHash;

    P_BaseState _currentState;
    P_StateFactory _states;

    //Variables to store player inputs
    Vector2 _currentMovementInput;
    Vector3 _currentMovement;
    Vector3 _currentSprintMovement;
    Vector3 _appliedMovement;
    Vector2 _currentLookInput;

    public Rigidbody _rigidbody;
    public Transform _cameraOrientation;
    public Transform _cameraPostion;
    public Animator _animator;
    //Transform _thisCharacter;

    float _mouseRotationX;
    float _mouseRotationY;

    Vector3 _moveForward;
    Vector3 _moveRight;

    bool _isMovementPressed;
    bool _isSprintPressed;
    bool _isJumpPressed;
    bool _isJumpReleased;
    bool _isDashPressed;
    bool _isDashReleased;
    bool _isSlidePressed;


    bool _isGrounded = false;



    //New Stuff
    Vector3 _slopeNormal;
    float _slopeAngle;
    float _realSlopeAngle;
    Vector3 _stateDirection;
    Vector3 _finalHorMovement;
    Vector3 _preCollideMovement;
    public float _dashFactor; // This manages the character's dash value and applies it to the character speed

    float _vertMagnitude;
    float _gravLerp;
    float _horMouseMod = 1f;
    Vector3 _subStateDirSet;
    Vector3 _relForward;


    float _stateMagnitude;
    public float _finalMagnitude;
    public float _actualMagnitude;

    Vector3 _botSphere;
    Vector3 _topSphere;

    Vector3 _gravDir = Vector3.down;


    SCR_abilityManager _pow = new SCR_abilityManager();

    PlayerWalking walking;

    public float _moveSpeed;
    public float climbspeed;
    public int IsClimbingHash { get { return _isClimbingHash; } }
    //Put a lot of getters and setters here
    public P_BaseState CurrentState { get { return _currentState; } set { _currentState = value; } }
    public Rigidbody Rigidbody { get { return _rigidbody; } }
    public Animator Animator { get { return _animator; } }
    public int IsWalkingHash { get { return _isWalkingHash; } }
    public int IsSprintingHash { get { return _isSprintingHash; } }
    public int IsFallingHash { get { return _isFallingHash; } }
    public int IsWallRunningHash { get { return _isWallRunningHash; } }
    public int IsSlidingHash { get { return _isSlidingHash; } }

    public Vector3 StateDirection { get { return _stateDirection; } set { _stateDirection = value; } }
    public float StateMagnitude { get { return _stateMagnitude; } set { _stateMagnitude = value; } }

    public Vector3 SubStateDirSet { get { return _subStateDirSet; } set { _subStateDirSet = value; } }
    public float VertMagnitude { get { return _vertMagnitude; } set { _vertMagnitude = value; } }
    public float ActualMagnitude { get { return _actualMagnitude; } set { _actualMagnitude = value; } }

    public float HorMouseMod { get { return _horMouseMod; } set { _horMouseMod = value; } }

    public Vector2 CurrentMovementInput { get { return _currentMovementInput; } set { _currentMovementInput = value; } }
    public Vector3 CurrentMovement { get { return _currentMovement; } set { _currentMovement = value; } }
    public Vector3 CurrentSprintMovement { get { return _currentSprintMovement; } set { _currentSprintMovement = value; } }
    public Vector3 AppliedMovement { get { return _appliedMovement; } set { _appliedMovement = value; } }
    public Vector3 RelForward { get { return _relForward; } }

    public Vector3 BotSphere { get { return _botSphere; } }
    public Vector3 TopSphere { get { return _topSphere; } }

    public Vector3 PreCollideMovement { get { return _preCollideMovement; } }

    public float CurrentMovementY { get { return _currentMovement.y; } set { _currentMovement.y = value; } }
    public float AppliedMovementY { get { return _appliedMovement.y; } set { _appliedMovement.y = value; } }
    public float AppliedMovementX { get { return _appliedMovement.x; } set { _appliedMovement.x = value; } }
    public float AppliedMovementZ { get { return _appliedMovement.z; } set { _appliedMovement.z = value; } }


    public SCR_abilityManager Pow { get { return _pow; } private set { _pow = value; }}


    public Vector3 SlopeNormal { get { return _slopeNormal; } }
    public float SlopeAngle { get { return _slopeAngle; } }

    public bool IsMovementPressed { get { return _isMovementPressed; } }
    public bool IsSprintPressed {  get { return _isSprintPressed; } }
    public bool IsJumpPressed { get { return _isJumpPressed; } }
    public bool IsJumpReleased { get { return _isJumpReleased; } }
    public bool IsDashPressed{ get { return _isDashPressed; } }
    public bool IsDashReleased { get { return _isDashReleased; } }
    public bool IsSlidePressed { get { return _isSlidePressed; } }

    public bool IsGrounded {  get { return _isGrounded; } set { _isGrounded = value; } }

    
    public Vector3 GravDirection { get { return _gravDir; } set { _gravDir = value; } }

    public static P_StateManager Instance { get; internal set; }

    public float CapsuleColliderHeight { get { return _capsuleCollider.height; } set { _capsuleCollider.height = value; } }

    //void Start()
    //{
    //    _avatar = GetComponentInParent<Alteruna.Avatar>();

    //}




    private void Awake()
    {

        walking = gameObject.GetComponentInParent<PlayerWalking>();
        _playerInput = new PlayerInput();
        //_rigidbody = GetComponent<Rigidbody>();
        _capsuleCollider = GetComponent<CapsuleCollider>();
        //_animator = GetComponent<Animator>();

        

        _bounds = _capsuleCollider.bounds;
        _bounds.Expand(-2 * _skindWidth);

        _dashFactor = 1;

        _isWalkingHash = Animator.StringToHash("isWalking");
        _isSprintingHash = Animator.StringToHash("isRunning");
        _isFallingHash = Animator.StringToHash("isFalling");
        _isWallRunningHash = Animator.StringToHash("isWallRunning");
        _isSlidingHash = Animator.StringToHash("isSliding");
        

        //This gets the inputs from the new input system
        _playerInput.PreyControls.Move.started += OnMovementInput;
        _playerInput.PreyControls.Move.canceled += OnMovementInput;
        _playerInput.PreyControls.Move.performed += OnMovementInput; //This allows the game to realize we might be holding two buttons at once (based). It also allows for controler inputs (cringe)
        _playerInput.PreyControls.Sprint.started += OnSprint;
        _playerInput.PreyControls.Sprint.canceled += OnSprint;
        _playerInput.PreyControls.Jump.started += OnJumpPress;
        _playerInput.PreyControls.Jump.canceled += OnJumpPress;
        _playerInput.PreyControls.Dash.started += OnDashPress;
        _playerInput.PreyControls.Dash.canceled += OnDashRelease;
        _playerInput.PreyControls.Slide.started += OnSlide;
        _playerInput.PreyControls.Slide.canceled += OnSlide;
        _playerInput.PreyControls.Slide.performed += OnSlide;
        _playerInput.PreyControls.Look.started += OnLookInput;
        _playerInput.PreyControls.Look.canceled += OnLookInput;
        _playerInput.PreyControls.Look.performed += OnLookInput;
        


        //setup state
        Pow = new SCR_abilityManager();
        _states = new P_StateFactory(this, Pow);
        _currentState = _states.Ground();
        _currentState.EnterState();


        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        

    }

    

    void Update()
    {
        //Add a Way so a remote avatar still makes sounds

        //if (!_avatar.IsMe)
        //    return;


        //if (_isMovementPressed && _isGrounded && !_isSprintPressed)
        //{
        //    walking.PlayWalkSound();
        //}

        //if (_isMovementPressed && _isGrounded && _isSprintPressed)
        //{
        //    walking.PlayRunSound();
        //}

        //Debug.Log("Right Wall: " + _wallRight);
        //Debug.Log("Left Wall: " + _wallLeft);
        _botSphere = _capsuleCollider.transform.position + new Vector3(0, _capsuleCollider.radius, 0);
        _topSphere = _capsuleCollider.transform.position + new Vector3(0, _capsuleCollider.height - _capsuleCollider.radius, 0);
        GroundCheck();
        if (!_isGrounded)
        {
            AntiClipCheck();
        }

        // Update ability manager
        //Pow.Update();
        
        SetCameraOrientation();
        
        RotateBodyY();
        _relForward = CamRelHor(Vector3.forward);
        //SlopeRelative();
        //testRelForward = Quaternion.AngleAxis(Quaternion.Angle(Quaternion.FromToRotation(testRelForward, _slopeNormal), testRelForward) , testRelForward) ;

        //NEED TO ROTATE THE Y AXIS OF THE MOVEMENT TO THE Y AXIS OF THE SLOPE
        //transform.rotation = Quaternion.Euler(0, y, 0);
        //testRelForward = Quaternion.FromToRotation(_relForward, _slopeNormal);

        
        //Debug.Log("Slope normal: " + _slopeNormal);

        //Debug.DrawRay(_cameraOrientation.position, TestCamRel(), Color.red, Time.deltaTime);
        
        _currentState.UpdateStates();

        _appliedMovement = AlignToSlope(_stateDirection);
        _preCollideMovement = _appliedMovement;
        _finalMagnitude = _stateMagnitude/* * _dashFactor*/;
        
        Debug.DrawRay(_rigidbody.transform.position, _relForward, Color.green, Time.deltaTime);
        _appliedMovement = CamRelHor(_appliedMovement);
        //_appliedMovement = Vector3.ProjectOnPlane(_appliedMovement, _slopeNormal);
        _appliedMovement = _appliedMovement.normalized;
        _appliedMovement *= _finalMagnitude;
        
        _actualMagnitude = _finalMagnitude;
        Debug.Log("SlopeAngle: " + _realSlopeAngle);
        _appliedMovement *= Time.deltaTime;
        
        //_vertMagnitude = Mathf.Max(_vertMagnitude + (_gravity * Time.deltaTime), -200f);
        
        Debug.DrawRay(_rigidbody.transform.position, _appliedMovement / Time.deltaTime, Color.red, Time.deltaTime);
        _appliedMovement = CollideAndSlide(_appliedMovement, _capsuleCollider.transform.position, 0, false, _appliedMovement);
        _appliedMovement += CollideAndSlide(_gravDir * -_vertMagnitude * Time.deltaTime, _capsuleCollider.transform.position + _appliedMovement, 0, true, _gravDir * -_vertMagnitude * Time.deltaTime);
        Debug.DrawRay(_rigidbody.transform.position, _appliedMovement / Time.deltaTime, Color.blue, Time.deltaTime);

        _rigidbody.transform.position += _appliedMovement;

        //Debug.Log("Grounded: " + _isGrounded);
        //Debug.Log("VertMagnitude: " + _vertMagnitude);
        //Debug.Log("Movement magnitude: " + _appliedMovement.magnitude / Time.deltaTime);
        //CheckClimbingState();
        
        
        //Reset params
        //_isJumpPressed = false;
        //_isJumpReleased = false;
        //_isDashPressed = false;
        //_isDashReleased = false;
    }


    //This function  based on this YT video https://www.youtube.com/watch?v=YR6Q7dUz2uk which in turn is based on this paper https://www.peroxide.dk/papers/collision/collision.pdf
    Vector3 CollideAndSlide(Vector3 vel, Vector3 startPos, int depth, bool gravityPass, Vector3 velInit)
    {
        
        //Debug.Log("StartPos: " + startPos);
        //Debug.Log("BotSphere: " + botSphere);
        //Debug.Log("TopSphere: " + topSphere);
        if (depth >= _maxBounces)
        {
            return Vector3.zero;
        }
        float dist = vel.magnitude + _skindWidth;
        RaycastHit hit;
        //Debug.Log("Direction: " + vel.normalized);
        //Debug.Log("Distance: " + dist);

        

        if (Physics.CapsuleCast(_botSphere, _topSphere, _bounds.extents.x, vel.normalized, out hit, dist))
        {
            Vector3 snapToSurface = vel.normalized * (hit.distance - _skindWidth);
            Vector3 leftover = vel - snapToSurface;
            
            

            float angle = Vector3.Angle(_gravDir * -1, hit.normal);

            if (snapToSurface.magnitude <= _skindWidth)
            {
                snapToSurface = Vector3.zero;
            }
            
            if (angle <= _maxSlopeAngle) //Normal ground / slope
            {
                if (gravityPass)
                {
                    return snapToSurface;
                }
                leftover = ProjectAndScale(leftover, hit.normal);
            }
            else //Wall or steep slope
            {
                float scale = 1 - Vector3.Dot(new Vector3(hit.normal.x, 0, hit.normal.z).normalized, -new Vector3(velInit.x, 0, velInit.z).normalized);
                
                if (_isGrounded && !gravityPass)
                {
                    leftover = ProjectAndScale(new Vector3(leftover.x, 0, leftover.z), new Vector3(hit.normal.x, 0, hit.normal.z))/*.normalized*/;
                    leftover *= scale;
                }
                else
                {
                    leftover = ProjectAndScale(leftover, hit.normal) * scale;
                }
            }

            return snapToSurface + CollideAndSlide(leftover, startPos + snapToSurface, depth + 1, gravityPass, velInit);
        }

        return vel;
    }
    //Part of CollideAndSlide
    Vector3 ProjectAndScale(Vector3 vec, Vector3 normal)
    {
        float magnitude = vec.magnitude;
        vec = Vector3.ProjectOnPlane(vec, normal).normalized;
        vec *= magnitude;
        return vec;
    }


    void GroundCheck()
    {
        RaycastHit hit;
        Physics.SphereCast(_botSphere, _bounds.extents.x, _gravDir, out hit, _skindWidth * 2f);
        if (hit.transform != null && Vector3.Angle(hit.normal, Vector3.up) <= _maxSlopeAngle)
        {
            _isGrounded = true;
            _slopeNormal = hit.normal;
            _slopeAngle = 90f - Vector3.Angle(_relForward, _slopeNormal);
            _realSlopeAngle = Vector3.Angle(-_gravDir, _slopeNormal);
        }
        else
        {
            _isGrounded = false;
            _slopeNormal = Vector3.zero;
            _slopeAngle = 0f;
            //_realSlopeAngle = 0f;
        }
    }

    void AntiClipCheck()
    {
        RaycastHit hit;
        Physics.Raycast(_rigidbody.transform.position, _gravDir, out hit, _capsuleCollider.height / 2);
        if (hit.transform != null)
        {
            _rigidbody.transform.position = hit.point + _gravDir.normalized * -1 * (0.05f + _capsuleCollider.height / 2f);
            _isGrounded = true;
            _slopeNormal = hit.normal;
            _slopeAngle = 90f - Vector3.Angle(_relForward, _slopeNormal);
            _realSlopeAngle = Vector3.Angle(-_gravDir, _slopeNormal);
        }
    }

    public Vector3 AlignToSlope(Vector3 inputDirection)
    {
        var slopeRotation = Quaternion.AngleAxis(_slopeAngle, Vector3.right);
        return slopeRotation * inputDirection;
    }

    //Replaced by CamRelHor
    //void RelativeMovement()
    //{
    //    float preRelativeY = _appliedMovement.y;
    //    _appliedMovement = _moveForward.normalized * _appliedMovement.z + _moveRight.normalized * _appliedMovement.x;
    //    _appliedMovement.y = preRelativeY;
    //}


    


    Vector3 CamRelHor(Vector3 input)
    {
        Vector3 camRelativeHor;
        //input = new Vector3(input.x, 0, input.z);
        camRelativeHor = _moveForward.normalized * input.z + _moveRight.normalized * input.x;
        camRelativeHor = new Vector3(camRelativeHor.x, input.y, camRelativeHor.z);
        return camRelativeHor;
    }

    public void OnJumpPress(InputAction.CallbackContext context)
    {
        _isJumpPressed = context.ReadValueAsButton();
    }


    public void OnDashPress(InputAction.CallbackContext context)
    {
        _isDashPressed = context.started;
        _isDashReleased = true;
    }

    public void OnDashRelease(InputAction.CallbackContext context)
    {
        _isDashReleased=context.started;
        _isDashPressed = false;
    }

    void OnSprint(InputAction.CallbackContext context)
    {
        _isSprintPressed = context.ReadValueAsButton();
    }

    void OnSlide(InputAction.CallbackContext context)
    {
        _isSlidePressed = context.ReadValueAsButton();
    }


    


    void OnMovementInput(InputAction.CallbackContext context)
    {
        _currentMovementInput = context.ReadValue<Vector2>();
        _isMovementPressed = _currentMovementInput.x != 0 || _currentMovementInput.y != 0;
        
    }

    void OnLookInput(InputAction.CallbackContext context)
    {
        _currentLookInput = context.ReadValue<Vector2>();
        _mouseRotationX -= _currentLookInput.y * Time.deltaTime * _mouseSens;
        _mouseRotationY += _currentLookInput.x * Time.deltaTime * _mouseSens * _horMouseMod;
        _mouseRotationX = Mathf.Clamp(_mouseRotationX, -89f, 89f);
    }

    public void SetCameraOrientation()
    {
        _cameraOrientation.rotation = Quaternion.Euler(_mouseRotationX, _mouseRotationY, 0);
        _moveForward = _cameraOrientation.forward;
        _moveRight = _cameraOrientation.right;
        _moveForward.y = 0;
        _moveRight.y = 0;
    }



    void RotateBodyY()
    {
        //Will add some kind of "only rotate when angle above x or moving" if case when i understand Quaternions
        var forward = _cameraOrientation.forward;
        forward.y = 0;
        _rigidbody.transform.rotation = Quaternion.LookRotation(forward, _rigidbody.transform.up);
    }


    
    
    

    //Use this as a cooldown for the mechanic of not losing momentum for a little bit when first entering a wallrun
    IEnumerator WallRunBuffer()
    {
        yield return new WaitForSeconds(2f);
        //getNoMomentumLoss = true
    }


   


    void OnEnable()
    {
        _playerInput.PreyControls.Enable();
    }

    void OnDisable()
    {
        _playerInput.PreyControls.Disable();
    }


}
