using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Character
{
    [SerializeField]MonsterStateMachine stateMachine;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        stateMachine.SwitchState(typeof(MonsterState_BeAttack));
    }
}
