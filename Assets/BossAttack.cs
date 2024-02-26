using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int count = 2;
    [SerializeField] float destroyTime = 7f;
    float damage;
    float finalPos;
    Rigidbody2D rb;
    public void Initialized(float damage, float finalPos)
    {
        this.damage = damage;
        this.finalPos = finalPos;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        // StartCoroutine(Destroy());
    }
    private void OnDisable()
    {
        count = 2;

    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(destroyTime);
        ObjectPool.Instance.PushObject(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().TakeDamage(count);
        }
        if (this.transform.position.y <= finalPos)
        {
            return;
        }
        if (other.CompareTag("PlayerAttack"))
        {
            count--;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            ObjectPool.Instance.PushObject(gameObject);
        }
        if (transform.position.y >= finalPos)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
