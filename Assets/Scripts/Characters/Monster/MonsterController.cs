using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    GroundDetector groundDetector;
    public GameObject player;
    [SerializeField] float chaseDistance = 5f;
    [SerializeField] float attackDistance = 1f;
    public bool canChase => Vector2.Distance(this.transform.position, player.transform.position) <= chaseDistance;
    public bool canAttack => Vector2.Distance(this.transform.position, player.transform.position) <= attackDistance;
    public Vector3 playerPos => player.transform.position;
    public float dir => playerPos.x - transform.position.x > 0 ? -1 : 1;
    public Vector2 dirVector => (playerPos - transform.position).normalized;
    GroundDetector wallDetector;

    [HideInInspector] public Rigidbody2D rb;
    virtual protected void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        player=GameObject.FindGameObjectWithTag("Player");
        // groundDetector = GetComponentInChildren<GroundDetector>();
        // wallDetector = GetComponentsInChildren<GroundDetector>()[1];
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(player.transform.position);
    }
    public void SetVelocity(Vector2 velocity)
    {
        rb.velocity = velocity;
    }
    public void SetVelocityX(float velocityX)
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }
    public void SetVelocityY(float velocityY)
    {
        rb.velocity = new Vector2(rb.velocity.x, velocityY);
    }
    public virtual void FlipTo(Vector3 target)
    {
        if (target == null) return;
        if (target.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    public void SetUseGravity(bool value)
    {
        rb.gravityScale = value ? 1f : 0f;
    }
}
