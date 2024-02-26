using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Idle", fileName = "PlayerState_Idle")]
public class PlayerState_Idle : PlayerState
{
    [SerializeField] float deceleration = 5f;
    public override void Enter()
    {
        base.Enter();
        currentSpeed = player.moveSpeed;
        // player.SetVelocityX(0f);
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (input.Move)
        {
            stateMachine.SwitchState(typeof(PlayerState_Run));
        }
        if (input.Jump)
        {
            stateMachine.SwitchState(typeof(PlayerState_JumpUp));
        }
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
        currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, Time.deltaTime * deceleration);
    }
    public override void PhysicsUpdate()
    {
        player.SetVelocityX(currentSpeed * player.transform.localScale.x);
    }
}
