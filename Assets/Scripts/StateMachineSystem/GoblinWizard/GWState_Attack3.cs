using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Attack3 : GWState
{
    [SerializeField] GameObject fireHead;
    [SerializeField] GameObject fireBody;
    [SerializeField] GameObject fireTail;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] float attack;
    [SerializeField] float fireTime = 2.5f;
    [SerializeField] float fireInterval = 3f;
    float timer = 0f;
    bool isAttack = false;
    GameObject Head;
    GameObject Body;
    GameObject Tail;
    GameObject father;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Enter Attack3");
        timer = Time.time;
    }

    public override void LogicUpdate()
    {
        if (!isAttack && Body == null)
        {
            lineRenderer.enabled = true;
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, monster.bulletPos.position);
            lineRenderer.SetPosition(1, monster.playerPos);
        }
        // StartCoroutine(Fire(fireTime));
        if (Time.time - timer >= fireInterval && lineRenderer.enabled)
        {
            Debug.Log("fire");
            timer = Time.time;
            lineRenderer.enabled = false;
            Body = ObjectPool.Instance.GetObject(fireBody);
            Body.GetComponent<Fire>().SetForce(attack);
            float distance = Vector2.Distance(monster.bulletPos.position, monster.playerPos) + 2f;
            Body.GetComponent<SpriteRenderer>().size = new Vector2(distance, 0.75f);
            Body.GetComponent<BoxCollider2D>().size = new Vector2(distance, 0.75f);
            Body.GetComponent<BoxCollider2D>().offset = new Vector2(-distance / 2, 0);

            Body.transform.position = monster.bulletPos.position;
            Body.transform.right = -(monster.playerPos - monster.firePos).normalized;
            StartCoroutine(FinishAttack());
        }
        // if (Body != null && !this.isAttack)
        // {
        //     float distance = Vector2.Distance(monster.bulletPos.position, monster.playerPos) + 2f;
        //     Body.GetComponent<SpriteRenderer>().size = new Vector2(distance, 0.75f);
        //     Body.GetComponent<BoxCollider2D>().size = new Vector2(distance, 0.75f);
        //     Body.transform.position = monster.bulletPos.position;
        //     Body.transform.right = Vector3.RotateTowards(Body.transform.right, -(monster.playerPos - monster.firePos).normalized, 0.1f, 0f);
        // }
        if (this.isAttack)
        {
            Debug.Log("Attack3Finish");
            stateMachine.SwitchState(typeof(GWState_Attack1));
            // StopCoroutine(Fire(fireTime));
            this.isAttack = false;
            lineRenderer.enabled = false;
            ObjectPool.Instance.PushObject(Body);
            Body = null;
            return;
        }
        // if (!monster.canAttack)
        // {
        //     stateMachine.SwitchState(typeof(GWState_Chase));
        //     return;
        // }

    }
    IEnumerator FinishAttack()
    {
        yield return new WaitForSeconds(1);
        this.isAttack = true;
    }
    public override void Exit()
    {
        base.Exit();
    }
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}
