using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    protected float attack;
    protected string user;
    public virtual void SetForce(Vector2 force, float attack, string user)
    {
        this.user = user;
        GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
        this.attack = attack;
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag != user)
        {
            if (collision.GetComponent<Character>() != null)
            {
                collision.GetComponent<Character>().TakeDamage(attack);
                DestroyBullet();
            }
            else if (collision.transform.tag == "Ground")
            {
                // DestroyBullet();
            }
        }


    }
    protected void DestroyBullet()
    {
        if (hitEffect != null)
        {
            GameObject effect = ObjectPool.Instance.GetObject(hitEffect);
            effect.transform.position = transform.position;
            effect.transform.rotation = Quaternion.identity;
            //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            //Destroy(effect, 0.1f);

        }

        //Destroy(gameObject);
        ObjectPool.Instance.PushObject(gameObject);
    }
}
