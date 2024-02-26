using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Attack1 : GWState
{
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected float damage;
    [SerializeField] protected float speed;
    [SerializeField] protected int bulletCount = 3;
    [SerializeField] protected Animator weaponAnimator;
    [SerializeField] protected float idleTime = 0.8f;
    protected GameObject bullet;
    protected bool canAttack = true;
    protected float timer = 0f;
    [SerializeField] protected float attackInterval = 1f;
    Rigidbody2D rb;
    PolygonCollider2D col;

    override public void Enter()
    {
        base.Enter();
        monster.SetVelocityX(0);

    }
    IEnumerator Attack()
    {
        canAttack = false;
        bullet = ObjectPool.Instance.GetObject(bulletPrefab);
        bullet.transform.position = monster.bulletPos.transform.position;
        Vector2 dir = (monster.playerPos - monster.bulletPos.transform.position).normalized;
        bullet.transform.right = -dir;
        yield return new WaitForSeconds(idleTime);
        bullet.GetComponent<Bullet>().SetForce(dir * speed, damage, monster.tag);
        if (bulletCount > 0)
            StartCoroutine(NextAttack());
    }
    IEnumerator NextAttack()
    {
        yield return new WaitForSeconds(attackInterval);
        // ObjectPool.Instance.PushObject(attack);
        canAttack = true;
        bulletCount--;
    }
    public override void Exit()
    {
        canAttack = true;
        bulletCount = 3;
    }
    override public void LogicUpdate()
    {
        if (canAttack)
            StartCoroutine(Attack());
        if (bulletCount <= 0)
        {

            stateMachine.SwitchState(typeof(GWState_Attack2));
            return;
        }

        // if (!monster.canChase)
        // {
        //     stateMachine.SwitchState(typeof(GWState_Chase));
        //     return;
        // }
    }
    override public void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        // monster.SetVelocityX(1* (monster.transform.localScale.x));
    }
}
