using UnityEngine;

//The base state for all the hunter states in the state machine - Love
public abstract class H_BaseState
{
    private bool _isRootState = false;
    protected H_StateManager _ctx;
    protected H_StateFactory _factory;
    protected H_BaseState _currentSubState;
    private H_BaseState _currentSuperState;

    protected bool hasDoubleJumped;
    public bool HasDoubleJumped { get { return hasDoubleJumped; } set { hasDoubleJumped = value; } }
    protected bool IsRootState { set { _isRootState = value; } }
    public H_BaseState CurrentSubState { get { return _currentSubState; } }

    //"currentContext" is the state manager and "p_StateFactory" is the library that creates the states and then keeps them for future use.
    //It's called a "factory" because I at the start had it create a new instance of the class whenever a state was switched but it got changed to just keep one instance of each.
    //Should be called "StateLibrary" but when I made the switch I was using the word factory in too many spots so I kept the old name. - Love
    public H_BaseState(H_StateManager currentContext, H_StateFactory p_StateFactory)
    {
        _ctx = currentContext;
        _factory = p_StateFactory;
    }

    //The EnterState and ExitState isn't what makes the code enter or exit the state, but rather the code that is ran once when the state is entered/exited - Love
    public abstract void EnterState();

    public abstract void ExitState();

    //The UpdateState method is called by the UpdateStates method which in turn is called from the state manager every frame - Love
    public abstract void UpdateState();

    public abstract void CheckSwitchState();

    //This method is called in the EnterState method for root states to set their sub state to the correct one - Love
    public abstract void InitializeSubState();

    //Important to note that this is called "UpdateState[s]", and not "UpdateState". This runs the update function on the current state and all its substates, which is what makes this state machine hierarchical instead of finite. - Love
    public void UpdateStates()
    {
        UpdateState();
        if (_currentSubState != null)
        {
            _currentSubState.UpdateStates();
        }
    }

    //The SwitchState method is what exits and enters new states by setting them as the new "target" for the UpdateStates function, as well as running the respective exit and enter state methods - Love
    protected void SwitchState(H_BaseState newState)
    {
        //Current state exits state
        ExitState();

        //New state enters state
        newState.EnterState();

        if (_isRootState)
        {
            //Switch current state of context
            _ctx.CurrentState = newState;
        }
        else if (_currentSuperState != null)
        {
            //Set the current super states sub state to the new state
            _currentSuperState.SetSubState(newState);
        }

    }

    protected void SetSuperState(H_BaseState newSuperState)
    {
        _currentSuperState = newSuperState;
    }

    protected void SetSubState(H_BaseState newSubState)
    {
        _currentSubState = newSubState;
        newSubState.SetSuperState(this);
    }

    //public void ExitStates()
    //{
    //    ExitState();
    //    if (_currentSubState != null)
    //    {
    //        _currentSubState.ExitStates();
    //    }
    //}
}