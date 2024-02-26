using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/BeAttack", fileName = "PlayerState_BeAttack")]

public class PlayerState_BeAttack : PlayerState
{
    [SerializeField] float impactForce = 10f;
    [SerializeField] float beAttackTime = 1f;
    public override void Enter()
    {
        base.Enter();
        // player.SetVelocityX(impactForce * player.flipX);

        // player.SetVelocityY(impactForce);
        player.beAttack = false;

    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (stateDuration >= beAttackTime)
        {
            stateMachine.SwitchState(typeof(PlayerState_Fall));
        }

    }
    public override void PhysicsUpdate()
    {
    }
    override public void Exit()
    {
        player.SetVelocityX(0);
        player.SetVelocityY(0);
    }
}
