using UnityEngine;
[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Fall", fileName = "PlayerState_Fall")]
public class PlayerState_Fall : PlayerState
{
    [SerializeField] AnimationCurve fallSpeedCurve;
    [SerializeField] float moveSpeed = 5f;
    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (player.isGrounded)
        {
            stateMachine.SwitchState(typeof(PlayerState_Land));
        }

        if (input.Jump)
        {
            if (player.canFallJump)
            {
                stateMachine.SwitchState(typeof(PlayerState_JumpUp));
                return;
            }
            if (player.canAirJump)
            {
                stateMachine.SwitchState(typeof(PlayerState_AirJump));
                return;
            }
            input.hasJumpInputBuffer = true;
        }
        
    }
    public override void PhysicsUpdate()
    {
        player.Move(player.isWallSliding ? 0f : moveSpeed);
        player.SetVelocityY(fallSpeedCurve.Evaluate(stateDuration));
    }
}
