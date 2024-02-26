using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Skill1", fileName = "PlayerState_Skill1")]

public class PlayerState_Skill1 : PlayerState
{
    [SerializeField] float attackTime = 0.2f;
    Animator childAnimator;
    override public void Enter()
    {
        base.Enter();
        player.playerAttack.Skill1();
    }
    override public void LogicUpdate()
    {
        base.LogicUpdate();

        if (stateDuration >= attackTime)
        {
            stateMachine.SwitchState(typeof(PlayerState_Fall));
        }
    }
    override public void PhysicsUpdate()
    {
        // player.SetVelocityX(0);
    }
}
