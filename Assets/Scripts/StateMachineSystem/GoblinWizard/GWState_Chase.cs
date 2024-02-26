using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Chase : GWState
{
    [SerializeField] float speed = 5f;
    [SerializeField] float acceleration = 5f;

    override public void Enter()
    {
        base.Enter();
        currentSpeed = 0;
    }

    override public void LogicUpdate()
    {
        // if (monster.canAttack)
        // {
        //     stateMachine.SwitchState(stateMachine.lastState.GetType());
        //     return;
        // }
        if (monster.canAttack)
        {
            stateMachine.SwitchState("Attack1");
            return;
        }
        currentSpeed = Mathf.MoveTowards(currentSpeed, speed, Time.deltaTime * acceleration);
    }
    override public void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        monster.SetVelocityX(currentSpeed * (monster.transform.localScale.x));

    }
}
