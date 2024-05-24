using UnityEngine;

public class P_IdleState : P_BaseState
{
    float lerpTime;
    public P_IdleState(P_StateManager currentContext, P_StateFactory p_StateFactory) : base(currentContext, p_StateFactory)
    {

    }

    public override void EnterState()
    {
        //_ctx.Animator.SetWalking(false);
        //_ctx.Animator.SetRunning(false);
        lerpTime = 0f;
    }



    public override void UpdateState()
    {
        _ctx.StateMagnitude = Mathf.Lerp(_ctx.ActualMagnitude, 0, lerpTime);
        lerpTime += Time.deltaTime;
        CheckSwitchState();
    }

    public override void ExitState()
    {
        
    }

    public override void CheckSwitchState()
    {
        if (_ctx.IsSlidePressed && _currentSuperState != _factory.Ghost())
        {
            SwitchState(_factory.Slide());
        }
        else if (_ctx.IsMovementPressed)
        {
            SwitchState(_factory.Walk());
        }
    }

    public override void InitializeSubState()
    {
        
    }
}