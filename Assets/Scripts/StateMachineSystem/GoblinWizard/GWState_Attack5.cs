using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Attack5 : GWState
{
    [SerializeField] GameObject attackPrefab;
    [SerializeField] float initialPos = -7.5f;
    [SerializeField] float finalPos = -3.55f;
    [SerializeField] float speed = 20f;
    [SerializeField] float idleTime = 0.8f;
    [SerializeField] float attackInterval = 5f;
    [SerializeField] float damage = 10f;
    [SerializeField] int attackCount = 3;
    GameObject attack;
    Rigidbody2D rb;
    PolygonCollider2D col;
    bool canAttack = true;

    public override void Enter()
    {
        base.Enter();

    }

    IEnumerator Attack()
    {
        canAttack = false;
        attack = ObjectPool.Instance.GetObject(attackPrefab);
        attack.GetComponent<BossAttack>().Initialized(damage, finalPos);
        attack.transform.position = new Vector2(monster.playerPos.x, initialPos);
        col = attack.GetComponent<PolygonCollider2D>();
        col.enabled = false;
        yield return new WaitForSeconds(idleTime);
        col.enabled = true;
        rb = attack.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        if (attackCount > 0)
            StartCoroutine(NextAttack());
    }
    IEnumerator NextAttack()
    {
        yield return new WaitForSeconds(attackInterval);
        // ObjectPool.Instance.PushObject(attack);
        canAttack = true;
        attackCount--;
    }


    public override void LogicUpdate()
    {
        if (canAttack)
            StartCoroutine(Attack());
        if (attackCount <= 0)
        {

            stateMachine.SwitchState(typeof(GWState_Attack1));
            return;
        }
    }
    public override void Exit()
    {
        canAttack = true;
        attackCount = 3;
    }
    public override void PhysicsUpdate()
    {
        if (attack == null)
        {
            return;
        }
        if (attack.transform.position.y >= finalPos)
        {
            rb.velocity = Vector2.zero;
        }
    }

}
