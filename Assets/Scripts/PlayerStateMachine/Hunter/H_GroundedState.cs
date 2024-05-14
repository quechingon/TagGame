using UnityEngine;

public class H_GroundedState : H_BaseState
{
    Vector3 direction;
    
    public H_GroundedState(H_StateManager currentContext, H_StateFactory p_StateFactory) : base(currentContext, p_StateFactory)
    {
        IsRootState = true;
    }

    public override void EnterState()
    {
        InitializeSubState();
        _ctx.Animator.SetBool(_ctx.IsFallingHash, false);
        _ctx.ActualMagnitude = _ctx.AppliedMovement.magnitude / Time.deltaTime;
        
        _ctx.VertMagnitude = -0.5f;

        direction = _ctx.SubStateDirSet;
        direction += new Vector3(_ctx.CurrentMovementInput.x, 0, _ctx.CurrentMovementInput.y);
        _ctx.StateDirection = direction;
    }

    public override void UpdateState()
    {
        CheckSwitchState();
        direction = _ctx.SubStateDirSet;
        direction += new Vector3(_ctx.CurrentMovementInput.x, 0, _ctx.CurrentMovementInput.y);
        _ctx.StateDirection = direction;
    }

    public override void ExitState()
    {

    }


    public override void InitializeSubState()
    {
        if (_ctx.IsSlidePressed)
        {
            SetSubState(_factory.Slide());
        }
        else if(_ctx.IsMovementPressed && _ctx.IsSprintPressed)
        {
            SetSubState(_factory.Run());
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

    public override void CheckSwitchState()
    {
        if (_ctx.IsJumpPressed && _currentSubState != _factory.Slide())
        {
            _ctx.VertMagnitude = 7.5f;
            _ctx.IsGrounded = false;
            SwitchState(_factory.Air());
        }
        else if (!_ctx.IsGrounded)
        {

            Debug.Log("Ground to air AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            _ctx.VertMagnitude = -Vector3.Project(_ctx.AppliedMovement / Time.deltaTime, _ctx.GravDirection).magnitude;
            
            SwitchState(_factory.Air());
        }
        
    }

}
