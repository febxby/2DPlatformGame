using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Attack", fileName = "PlayerState_Attack")]
public class PlayerState_Attack : PlayerState
{
    [SerializeField] float attackTime = 0.2f;
    [SerializeField] float attackMoveSpeed = 2f;
    [SerializeField] float moveSpeed = 3.5f;
    [SerializeField] AudioClip attackSFX;
    Animator childAnimator;
    override public void Enter()
    {
        base.Enter();
        player.playerVoice.PlayOneShot(attackSFX);
        player.SetVelocityX(attackMoveSpeed * player.transform.localScale.x);
        player.playerAttack.Attack();
    }
    override public void LogicUpdate()
    {
        base.LogicUpdate();

        if (stateDuration >= attackTime)
        {
            stateMachine.SwitchState(typeof(PlayerState_Fall));
        }
        if (player.isAttack)
        {
            stateMachine.SwitchState(typeof(PlayerState_AirAttack));
        }
        if (player.isSkill1)
        {
            stateMachine.SwitchState(typeof(PlayerState_Skill1));
        }
        if (input.Jump)
        {
            stateMachine.SwitchState(typeof(PlayerState_JumpUp));
        }

    }
    override public void PhysicsUpdate()
    {
        // player.SetVelocityX(0);
        // player.SetVelocityX(moveSpeed * input.AxisX);
    }
}
