using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceBullet : Bullet
{
    public float lerp;
    public float speed;
    private Rigidbody2D rb;
    private Vector3 targetPos;
    public Player pos;
    private Vector3 direction;
    private bool arrived;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void SetTarget(Vector2 target, string user, float damage, float speed)
    {
        attack = damage;
        this.user = user;
        arrived = false;
        targetPos = target;
        this.speed = speed;
    }
    private void FixedUpdate()
    {
        direction = (pos.transform.position - transform.position).normalized;
        if (!arrived)
        {
            transform.right = Vector3.Slerp(transform.right, direction, lerp / Vector2.Distance(transform.position, pos.transform.position));
            rb.velocity = transform.right * speed;
        }
        if (Vector2.Distance(transform.position, pos.transform.position) < 1f && !arrived)
        {
            arrived = true;
        }
    }
}
