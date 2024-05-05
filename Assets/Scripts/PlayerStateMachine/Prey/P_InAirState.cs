using System;
using UnityEngine;

public class P_InAirState : P_BaseState
{

    Vector3 direction;

    public P_InAirState(P_StateManager currentContext, P_StateFactory p_StateFactory, SCR_abilityManager scr_pow) : base(currentContext, p_StateFactory, scr_pow)
    {
        IsRootState = true;
    }

    public override void EnterState()
    {
        InitializeSubState();
        _ctx.Animator.SetBool(_ctx.IsFallingHash, true);
        
    }

    public override void UpdateState()
    {
        CheckSwitchState();
        direction = _ctx.AppliedMovement;
        direction += new Vector3(_ctx.CurrentMovementInput.x, 0, _ctx.CurrentMovementInput.y);
        //direction *= 0.5f;
        _ctx.StateDirection = direction;
        _ctx.VertMagnitude -= 10f * Time.deltaTime;
        _pow.CheckDoubleJump(ref _ctx);
    }

    public override void ExitState()
    {
        
    }

    public override void CheckSwitchState()
    {
        if (_ctx.IsGrounded)
        {
            SwitchState(_factory.Ground());
            _pow.ResetJumps();
        }
        
    }

    public override void InitializeSubState()
    {
        if (_ctx.IsSlidePressed)
        {
            SetSubState(_factory.Slide());
        }
        else if (_ctx.IsMovementPressed && !_ctx.IsSprintPressed)
        {
            SetSubState(_factory.Walk());
        }
        else
        {
            SetSubState(_factory.Idle());
        }
    }

    //void HandleGravity()
    //{
    //    bool goingDown = _ctx.CurrentMovementY <= 2.0f || !_ctx.IsJumpPressed;
    //    float fallMultiplier = 2f;

    //    if (goingDown)
    //    {
    //        float previousYVelocity = _ctx.CurrentMovementY;
    //        _ctx.CurrentMovementY = _ctx.CurrentMovementY + (_ctx.Gravity * fallMultiplier * Time.deltaTime);
    //        _ctx.AppliedMovementY = Mathf.Max((previousYVelocity + _ctx.CurrentMovementY) * .5f, -10.0f);
    //    }
    //    else
    //    {
    //        float previousYVelocity = _ctx.CurrentMovementY;
    //        _ctx.CurrentMovementY = _ctx.CurrentMovementY + (_ctx.Gravity * Time.deltaTime);
    //        _ctx.AppliedMovementY = (previousYVelocity + _ctx.CurrentMovementY) * .5f;
    //    }
    //}
}