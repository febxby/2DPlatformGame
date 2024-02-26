using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Idle : GWState
{
    [SerializeField] float idleTime = 2f;
    public override void Enter()
    {
        base.Enter();
        monster.SetVelocityX(0f);
        monster.SetVelocityY(0f);
    }
    public override void LogicUpdate()
    {
        if (monster.attack1 && stateDuration >= idleTime && monster.canAttack)
        {
            stateMachine.SwitchState(typeof(GWState_Attack1));
        }

    }
    public override void PhysicsUpdate()
    {

    }

}
