using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "PlayerState_Run")]
public class PlayerState_Run : PlayerState
{
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float acceleration = 5f;
    public override void Enter()
    {
        base.Enter();
        currentSpeed = player.moveSpeed;
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (!input.Move)
        {
            stateMachine.SwitchState(typeof(PlayerState_Idle));
        }
        if (input.Jump)
        {
            stateMachine.SwitchState(typeof(PlayerState_JumpUp));
        }
        if(player.isFalling){
            stateMachine.SwitchState(typeof(PlayerState_CoyoteTime));
        }
        if (player.isAttack)
        {
            stateMachine.SwitchState(typeof(PlayerState_Attack));
        }
        if(player.beAttack){
            stateMachine.SwitchState(typeof(PlayerState_BeAttack));
        }
        if(player.isSkill1){
            stateMachine.SwitchState(typeof(PlayerState_Skill1));
        }
        currentSpeed = Mathf.MoveTowards(currentSpeed, runSpeed, Time.deltaTime * acceleration);
    }
    public override void PhysicsUpdate()
    {
        player.Move(currentSpeed);
    }
}
