using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWController : MonsterController
{
    // Start is called before the first frame update
    public bool attack1 = false;
    public Transform bulletPos;
    public Vector3 firePos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        firePos = transform.TransformPoint(bulletPos.localPosition);
    }
    public void StartAttack1()
    {
        attack1 = true;
    }
    public override void FlipTo(Vector3 target)
    {
        if (target == null) return;
        if (target.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    public void MoveTo()
    {

    }
}
