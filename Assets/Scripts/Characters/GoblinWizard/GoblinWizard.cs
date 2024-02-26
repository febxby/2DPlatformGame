using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinWizard : Character
{
    // Start is called before the first frame update
    [SerializeField] CharacterUI characterUI;
    [SerializeField] GWStateMachine stateMachine;
    public float Health => health / maxHealth;

    void Start()
    {

    }
    private void OnEnable()
    {
        health = maxHealth;
        characterUI.Init(Health, 1);
    }
    // Update is called once per frame
    void Update()
    {
        characterUI?.UpdateHealthBar(Health);
    }
    private void OnDisable()
    {
        characterUI.UpdateHealthBar(0);
    }
    public override void Die()
    {
        base.Die();
        UnityEngine.SceneManagement.SceneManager.LoadScene("End");

    }
    override public void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        GetComponent<Animator>().CrossFade(Animator.StringToHash("BeAttack"), 0.1f);

    }
}
