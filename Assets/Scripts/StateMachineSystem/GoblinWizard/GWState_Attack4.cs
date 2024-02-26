using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWState_Attack4 : GWState
{
    [SerializeField] GameObject[] pos;
    [SerializeField] GameObject firePrefab;
    [SerializeField] float attackInterval = 1.5f;
    [SerializeField] protected float attack;
    [SerializeField] protected float speed;
    float timer;
    GameObject fire;
    LineRenderer line;
    int index = 0;
    Vector2 dir;
    bool isAttack = true;
    public override void Enter()
    {
        base.Enter();
        index = 0;
        // Debug.Log("Enter Attack4");
    }
    public override void LogicUpdate()
    {
        if (Time.time - timer >= attackInterval && index < pos.Length && isAttack)
        {
            isAttack = false;
            timer = Time.time;
            line = pos[index].GetComponent<LineRenderer>();
            line.enabled = true;
            line.positionCount = 2;
            line.SetPosition(0, pos[index].transform.position);
            line.SetPosition(1, monster.playerPos);
            dir = (monster.playerPos - pos[index].transform.position).normalized;
            StartCoroutine(Attack());
        }
        else if (index == pos.Length)
        {
            // for (int i = 0; i < pos.Length; i++)
            // {
            //     index = 0;
            //     line = pos[i].GetComponent<LineRenderer>();
            //     line.positionCount = 2;
            //     line.SetPosition(0, pos[i].transform.position);
            //     line.SetPosition(1, monster.playerPos);
            //     dir = (monster.playerPos - pos[i].transform.position).normalized;
            //     StartCoroutine(Attack());
            // }
            StartCoroutine(FinishAttack());
        }
    }
    IEnumerator FinishAttack()
    {
        yield return new WaitForSeconds(5);
        stateMachine.SwitchState(typeof(GWState_Attack1));

    }
    IEnumerator Attack()
    {
        yield return new WaitForSeconds(2f);
        line.enabled = false;
        isAttack = true;
        fire = ObjectPool.Instance.GetObject(firePrefab);
        fire.transform.position = pos[index].transform.position;
        fire.GetComponent<Bullet>().SetForce(speed * dir, attack, monster.tag);
        index++;
    }
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}
