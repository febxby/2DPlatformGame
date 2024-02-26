using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTMState : MonoBehaviour, IState
{
    [SerializeField] string stateName;
    [SerializeField, Range(0f, 1f), Header("动画过渡时间")] float transitionDuration = 0.1f;
    float stateStartTime;
    int stateHash;
    protected Animator animator;
    protected CTMController monster;
    protected CTMStateMachine stateMachine;
    protected float currentSpeed;
    protected bool isAnimationFinished => stateDuration >= animator.GetCurrentAnimatorStateInfo(0).length;
    //状态持续时间
    protected float stateDuration => Time.time - stateStartTime;

    void OnEnable()
    {
        stateHash = Animator.StringToHash(stateName);
    }
    public void Initialize(Animator animator, CTMController monster, CTMStateMachine stateMachine)
    {
        this.animator = animator;
        this.monster = monster;
        this.stateMachine = stateMachine;
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

    }

    public virtual void PhysicsUpdate()
    {

    }
}
