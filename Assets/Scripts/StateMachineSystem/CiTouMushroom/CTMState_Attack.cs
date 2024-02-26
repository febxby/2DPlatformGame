using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTMState_Attack : CTMState
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float attackInterval = 0.5f;
    [SerializeField] Transform firePoint;
    [SerializeField] protected float speed;
    [SerializeField] protected float attack;

    float timer = 0;
    GameObject bullet;
    override public void Enter()
    {
        base.Enter();
        // timer = stateDuration - attackInterval;

    }
    override public void LogicUpdate()
    {
        // if (!monster.canAttack)
        // {
        //     stateMachine.SwitchState(typeof(MonsterState_Patrol));
        // }
        if (Time.time - timer >= attackInterval)
        {
            timer = Time.time;
            bullet = ObjectPool.Instance.GetObject(bulletPrefab);
            bullet.transform.position = firePoint.position;
            Vector2 dir = (monster.transform.localScale.x * Vector2.right).normalized;
            bullet.transform.right = dir;
            bullet.GetComponent<Bullet>().SetForce(-dir * speed, attack, monster.tag);
        }
        if (!monster.isAttackDetected || !monster.canAttack)
        {
            stateMachine.SwitchState(typeof(MonsterState_Chase));
        }
    }
    override public void PhysicsUpdate()
    {
        monster.FlipTo(monster.playerPos);
        monster.SetVelocityX(0);
    }
}
