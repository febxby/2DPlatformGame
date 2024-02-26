using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiTouMushroom : Character

{
    [SerializeField] CTMStateMachine stateMachine;
    // Start is called before the first frame update
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
