using System.Xml.Serialization;
using UnityEngine;

public class P_WalkingState : P_BaseState
{
    public P_WalkingState(P_StateManager currentContext, P_StateFactory p_StateFactory) : base(currentContext, p_StateFactory)
    {

    }

    public override void EnterState()
    {
        _ctx.Animator.SetBool(_ctx.IsWalkingHash, true);
        _ctx.Animator.SetBool(_ctx.IsSprintingHash, false);
    }

    public override void UpdateState()
    {
        _ctx.AppliedMovementX = _ctx.CurrentMovementInput.x * _ctx._moveSpeed;
        _ctx.AppliedMovementZ = _ctx.CurrentMovementInput.y * _ctx._moveSpeed;
        //Debug.Log("Current movement in walk: " + _ctx.CurrentMovement);
        CheckSwitchState();
    }

    public override void ExitState()
    {

    }

    public override void CheckSwitchState()
    {
        
        if (!_ctx.IsMovementPressed)
        {
            SwitchState(_factory.Idle());
        }
        else if (_ctx.IsMovementPressed && _ctx.IsSprintPressed)
        {
            SwitchState(_factory.Run());
        }

    }

    public override void InitializeSubState()
    {
        //if (slide) -> slide
    }

}