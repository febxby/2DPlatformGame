using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTMState_Chase : CTMState
{
    [SerializeField] float speed = 2f;
    override public void Enter()
    {
        base.Enter();
    }
    override public void LogicUpdate()
    {
        if (!monster.canChase||!monster.isChaseDetected)
        {
            stateMachine.SwitchState(typeof(MonsterState_Patrol));
        }
        if (monster.canAttack&&monster.isAttackDetected)
        {
            stateMachine.SwitchState(typeof(MonsterState_Attack));
        }
    }
    override public void PhysicsUpdate()
    {
        Vector2 target = monster.player.transform.position;
        monster.FlipTo(target);
        monster.SetVelocityX(speed * (-monster.transform.localScale.x));
    }
}
