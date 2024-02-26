using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    
    [SerializeField] protected float maxHealth = 100f;
    [SerializeField] GameObject[] dropItem;
    protected float health;
    private void OnEnable()
    {
        health = maxHealth;
    }
    public virtual void TakeDamage(float damage)
    {
        if (this.tag == "Monster")
        {
            CameraShake.Instance.ShakeCamera(3f, 0.3f);
        }
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }
    public virtual void Die()
    {
        if (this.tag == "Monster")
        {
            int index = (int)Random.Range(0f, (float)dropItem.Length);

            Instantiate(dropItem[index], transform.position, Quaternion.identity);
        }
        health = 0;
        gameObject.SetActive(false);
    }
    public virtual void RestoreHealth(float health)
    {
        this.health += health;
        if (this.health > maxHealth)
        {
            this.health = maxHealth;
        }
    }
}
