using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/AirJump", fileName = "PlayerState_AirJump")]
public class PlayerState_AirJump : PlayerState
{
    [SerializeField] float jumpForce = 5f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] AudioClip jumpSFX;

    public override void Enter()
    {
        base.Enter();
        player.playerVoice.PlayOneShot(jumpSFX);
        player.canAirJump = false;
        player.SetVelocityY(jumpForce);
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (player.isFalling)
        {
            stateMachine.SwitchState(typeof(PlayerState_Fall));
        }
        if (player.isAttack)
        {
            stateMachine.SwitchState(typeof(PlayerState_Attack));
        }
        if (player.beAttack)
        {
            stateMachine.SwitchState(typeof(PlayerState_BeAttack));
        }
        if (player.isSkill1)
        {
            stateMachine.SwitchState(typeof(PlayerState_Skill1));
        }
    }
    public override void PhysicsUpdate()
    {
        player.Move(player.isWallSliding ? 0f : moveSpeed);
    }
}
