using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Attack : GWState
{
    override public void Enter()
    {
        base.Enter();
    }
    override public void LogicUpdate()
    {
        // if (!monster.canAttack)
        // {
        //     stateMachine.SwitchState(typeof(MonsterState_Patrol));
        // }
        if (isAnimationFinished)
        {
            stateMachine.SwitchState(typeof(MonsterState_Chase));
        }
    }
    override public void PhysicsUpdate()
    {
        monster.FlipTo(monster.playerPos);
        monster.SetVelocityX(0);
    }
}
