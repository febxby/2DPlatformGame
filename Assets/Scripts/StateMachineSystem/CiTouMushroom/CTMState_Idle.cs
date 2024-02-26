using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTMState_Idle : CTMState
{
    [SerializeField] float idleTime = 2f;
    public override void Enter()
    {
        base.Enter();
        monster.SetVelocityX(0f);
    }
    public override void LogicUpdate()
    {
        if (stateDuration >= idleTime)
        {
            stateMachine.SwitchState(typeof(MonsterState_Patrol));
        }
    }
    public override void PhysicsUpdate()
    {

    }

}
