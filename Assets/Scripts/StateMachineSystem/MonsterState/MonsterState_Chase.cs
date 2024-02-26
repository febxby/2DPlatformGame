using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterState_Chase : MonsterState
{
    [SerializeField] protected float speed = 6f;

    override public void Enter()
    {
        base.Enter();
    }
    override public void LogicUpdate()
    {
        if (!monster.canChase)
        {
            stateMachine.SwitchState(typeof(MonsterState_Patrol));
        }
        if (monster.canAttack)
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
