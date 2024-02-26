using System.Diagnostics.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class MonsterState_Patrol : MonsterState
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform[] patrolPoints;

    int currentPatrolIndex = 0;
    public override void Enter()
    {
        base.Enter();
    }
    public override void LogicUpdate()
    {
        if (monster.canChase)
        {
            stateMachine.SwitchState(typeof(MonsterState_Chase));
        }
    }
    public override void PhysicsUpdate()
    {
        Vector2 target = this.transform.TransformDirection(patrolPoints[currentPatrolIndex].position);

        monster.FlipTo(target);
        // Debug.Log(monster.transform.position);
        monster.SetVelocityX(speed * (-monster.transform.localScale.x));
        if (Vector2.Distance(monster.transform.position, target) <= 1f)
        {
            // Debug.Log(currentPatrolIndex);

            stateMachine.SwitchState(typeof(MonsterState_Idle));
        }
    }
    public override void Exit()
    {
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
    }
}
