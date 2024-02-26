using System.Collections.Generic;
using UnityEngine;
using System;
public class StateMachine : MonoBehaviour
{
    protected Dictionary<System.Type, IState> stateTable;
    protected Dictionary<String, IState> stateTable1;
    protected IState currentState;
    public IState lastState;
    void Update()
    {

        currentState?.LogicUpdate();
    }
    void FixedUpdate()
    {
        currentState?.PhysicsUpdate();
    }
    protected void SwitchOn(IState newState)
    {

        currentState = newState;
        currentState.Enter();
    }
    public void SwitchState(IState newState)
    {
        lastState = currentState;
        currentState?.Exit();
        SwitchOn(newState);
    }
    public void SwitchState(System.Type newStateType)
    {
        SwitchState(stateTable1[newStateType.ToString().Split('_')[1]]);
        // SwitchState(stateTable[newStateType]);
    }
    public void SwitchState(String newState)
    {
        SwitchState(stateTable1[newState]);
    }

}
