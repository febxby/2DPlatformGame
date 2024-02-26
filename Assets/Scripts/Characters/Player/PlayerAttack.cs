using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerController player;
    PlayerInput input;
    Animator animator;
    [SerializeField] float attackDamage = 5f;
    [SerializeField] float airAttackDamage = 5f;
    [SerializeField] float skill1Damage = 20f;
    [SerializeField] float swordDamage=10f;
    public float Skill1Cost = 10f;
    float attack;
    private void Awake()
    {
        player = GetComponentInParent<PlayerController>();
        input = GetComponentInParent<PlayerInput>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SwordAttack(){
        attack = swordDamage;
        animator.SetTrigger("SwordAttack");
    }
    public void Attack()
    {
        attack = attackDamage;
        animator.SetTrigger("Attack");
    }
    public void AirAttack(){
        attack = airAttackDamage;
        animator.SetTrigger("AirAttack");
    }
    public void Skill1(){
        attack = skill1Damage;
        animator.SetTrigger("Skill1");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            // Debug.Log(attack);
            other.GetComponent<Character>().TakeDamage(attack);
        }
    }
}
