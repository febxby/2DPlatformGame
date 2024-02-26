using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    [SerializeField] string stateName;

    [SerializeField, Range(0f, 1f), Header("动画过渡时间")] float transitionDuration = 0.1f;
    float stateStartTime;
    int stateHash;
    protected PlayerInput input;
    protected Animator animator;
    protected PlayerStateMachine stateMachine;
    protected PlayerController player;
    protected float currentSpeed;
    protected bool isAnimationFinished => stateDuration >= animator.GetCurrentAnimatorStateInfo(0).length;
    //状态持续时间
    protected float stateDuration => Time.time - stateStartTime;

    void OnEnable()
    {
        stateHash = Animator.StringToHash(stateName);
    }
    public void Initialize(Animator animator, PlayerController player, PlayerInput input, PlayerStateMachine stateMachine)
    {
        this.animator = animator;
        this.input = input;
        this.stateMachine = stateMachine;
        this.player = player;
    }
    public virtual void Enter()
    {
        animator.CrossFade(stateHash, transitionDuration);
        stateStartTime = Time.time;
    }

    public virtual void Exit()
    {
    }

    public virtual void LogicUpdate()
    {
        // if (input.isUseItem)
        // {
        //     stateMachine.SwitchState(typeof(PlayerState_Equip));
        // }
    }

    public virtual void PhysicsUpdate()
    {

    }
}
