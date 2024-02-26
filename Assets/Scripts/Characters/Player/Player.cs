using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    [SerializeField] float maxMagic = 100f;
    [SerializeField] CharacterUI characterUI;
    [SerializeField] bool test = false;
    float magic;
    public bool isMagicEnough(float magic)
    {
        if (this.magic >= magic)
        {
            UseMagic(magic);
            return true;
        }
        else
        {
            return false;
        }
    }
    PlayerData temp;
    public float Magic => magic / maxMagic;
    public float Health => health / maxHealth;
    // Start is called before the first frame update
    private void Awake()
    {
        temp = SaveSystem.LoadFromJson<PlayerData>("Player");
        if (temp != default(PlayerData))
        {
            transform.position = temp.position;
        }
        else
        {

        }
    }
    private void OnEnable()
    {
        health = maxHealth;
        magic = maxMagic;
        // magic = 10;
        characterUI.Init(Health, Magic);
    }
    void Start()
    {

    }
    private void OnDestroy()
    {
        SaveSystem.SaveByJson("Player", new PlayerData()
        {
            position = transform.position.x >= 147 ? new Vector2(147, 0) : transform.position
        });
    }
    // Update is called once per frame
    void Update()
    {
        characterUI.UpdateHealthBar(Health);
        characterUI.UpdateMagicBar(Magic);
    }
    public void UseMagic(float magic)
    {
        this.magic -= magic;
        if (this.magic <= 0)
        {
            this.magic = 0;
        }
    }
    public virtual void RestoreMagic(float magic)
    {
        this.magic += magic;
        if (this.magic > maxMagic)
        {
            this.magic = maxMagic;
        }
    }
    public override void TakeDamage(float damage)
    {
        if (test)
            return;
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    override public void Die()
    {
        base.Die();
        UnityEngine.SceneManagement.SceneManager.LoadScene("End");
    }
}
