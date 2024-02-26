using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Attack2 : GWState_Attack1
{
    [SerializeField] protected float bulletAngle = 15f;
    [SerializeField] Transform attackPos;
    int count;
    public override void Enter()
    {
        // monster.transform.position = attackPos.position;
        base.Enter();
        count = bulletCount;
        monster.SetVelocityX(0);

    }
    IEnumerator Attack()
    {
        canAttack = false;
        int medium = bulletCount / 2;
        yield return new WaitForSeconds(idleTime);

        for (int i = 0; i < bulletCount; i++)
        {
            GameObject bullet = ObjectPool.Instance.GetObject(bulletPrefab);
            bullet.transform.position = monster.bulletPos.transform.position;
            bullet.transform.localScale = new Vector3(-1, 1, 1);
            // bullet.transform.rotation = s
            if (bulletCount % 2 == 1)
            {
                bullet.transform.right = (Quaternion.AngleAxis(bulletAngle * (i - medium), Vector3.forward) * monster.dirVector);

            }
            else
            {
                bullet.transform.right = (Quaternion.AngleAxis(bulletAngle * (i - medium) + bulletAngle / 2, Vector3.forward) * monster.dirVector);
            }
            // bullet.GetComponent<TraceBullet>().SetTarget(monster.playerPos, monster.tag, damage, speed);
            bullet.GetComponent<Bullet>().SetForce(transform.right * speed, damage, monster.tag);
        }
        if (count > 0)
            StartCoroutine(NextAttack());
    }
    IEnumerator NextAttack()
    {
        yield return new WaitForSeconds(attackInterval);
        // ObjectPool.Instance.PushObject(attack);
        canAttack = true;
        count--;
    }
    public override void LogicUpdate()
    {
        if (canAttack)
            StartCoroutine(Attack());
        if (count <= 0)
        {

            stateMachine.SwitchState(typeof(GWState_Attack5));
            return;
        }
        // if (this.isAttack)
        // {

        //     return;
        // }
        // if (!monster.canAttack)
        // {
        //     stateMachine.SwitchState(typeof(GWState_Chase));
        //     return;
        // }
    }
    public override void Exit()
    {
        canAttack = true;
        count = bulletCount;
    }
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        // monster.SetUseGravity(false);
    }

}
