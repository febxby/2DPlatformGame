using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/AirAttack", fileName = "PlayerState_AirAttack")]
public class PlayerState_AirAttack : PlayerState
{
    [SerializeField] float attackTime = 0.5f;
    [SerializeField] float attackMoveSpeed = 2f;
    [SerializeField] float moveSpeed = 3.5f;
    [SerializeField] AudioClip attackSFX;

    Animator childAnimator;
    override public void Enter()
    {
        base.Enter();
        player.playerVoice.PlayOneShot(attackSFX);
        player.SetVelocityX(attackMoveSpeed * player.transform.localScale.x);
        player.playerAttack.AirAttack();
    }
    override public void LogicUpdate()
    {
        base.LogicUpdate();
        if (stateDuration >= attackTime)
        {
            stateMachine.SwitchState(typeof(PlayerState_Fall));
        }
        if (player.isSkill1)
        {
            stateMachine.SwitchState(typeof(PlayerState_Skill1));
        }
        if (input.Jump)
        {
            stateMachine.SwitchState(typeof(PlayerState_JumpUp));
            
        }
        // if (input.isAttack)
        // {
        //     stateMachine.SwitchState(typeof(PlayerState_Attack));
        // }
    }
    override public void PhysicsUpdate()
    {
        
        // player.SetVelocityX(moveSpeed * player.transform.localScale.x);

    }
}
