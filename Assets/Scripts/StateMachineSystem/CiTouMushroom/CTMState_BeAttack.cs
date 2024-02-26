using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTMState_BeAttack : CTMState
{
    [SerializeField] float force = 2f;
    public override void Enter()
    {
        base.Enter();
        monster.rb.AddForce(new Vector2(monster.dir * force, 0), ForceMode2D.Impulse);
    }
    public override void LogicUpdate()
    {
        // base.LogicUpdate();
        if(isAnimationFinished)
        {
            stateMachine.SwitchState(typeof(MonsterState_Idle));
        }
    }
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
    public override void Exit()
    {
        monster.SetVelocityX(0);
        monster.SetVelocityY(0);
    }
}
