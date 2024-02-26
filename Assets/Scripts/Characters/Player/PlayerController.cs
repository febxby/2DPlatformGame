using System.Diagnostics.Contracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerController : MonoBehaviour
{
    GroundDetector groundDetector;
    public AudioSource playerVoice;
    Player player;
    GroundDetector wallDetector;
    PlayerInput input;
    Rigidbody2D rb;
    Collider2D boxCollider;
    SpriteRenderer spriteRenderer;
    public PlayerAttack playerAttack;
    EquipManager equip;
    //当前移动速度
    public bool isFlipX => transform.localScale.x == -1;
    public float flipX => isFlipX ? -1 : 1;
    float dir;
    public float moveSpeed => Mathf.Abs(rb.velocity.x);
    public bool isGrounded => groundDetector.isGrounded;
    public bool isWallSliding => wallDetector.isGrounded;
    public bool isFalling => rb.velocity.y < 0 && !isGrounded;
    public bool isSkill1 => input.isSkill1 && player.isMagicEnough(playerAttack.Skill1Cost);
    public bool isAttack => input.isAttack && !input.isUseItem;
    public bool canAirJump { get; set; } = true;
    public bool canFallJump { get; set; } = true;
    public bool beAttack { get; set; } = false;
    public bool canBeAttack { get; set; } = true;
    public float beAttackTime = 1f;
    float beAttackTimer = 0f;
    public GameObject bag;
    public GameObject instruction;
    Color originColor;
    [SerializeField] float flashTimer = 0.2f;
    Item equipItem;

    void Awake()
    {
        input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
        groundDetector = GetComponentInChildren<GroundDetector>();
        wallDetector = GetComponentsInChildren<GroundDetector>()[1];
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        originColor = spriteRenderer.color;
        playerAttack = GetComponentInChildren<PlayerAttack>();
        player = GetComponent<Player>();
        playerVoice = GetComponentInChildren<AudioSource>();
        equip = GetComponent<EquipManager>();
    }
    void Start()
    {
        input.EnableGameplayInput();
    }
    void Update()
    {
        if (input.isExit)
        {
            Application.Quit();
        }
        if (input.openBag)
        {
            Time.timeScale = 0;
            input.EnableBagInput();
            input.DisableGameplayInput();
            bag.SetActive(true);
            InventoryManager.RefreshItem();
            // InventoryManager.SaveItems();
        }
        if (input.closeBag)
        {
            Time.timeScale = 1;
            input.DisableBagInput();
            input.EnableGameplayInput();
            bag.SetActive(false);
        }
        if (input.openInstruction)
        {
            OpenInstruction();
        }
        if (input.closeInstruction)
        {
            Time.timeScale = 1;
            input.DisableInstructionInput();
            input.EnableGameplayInput();
            instruction.SetActive(false);
        }

    }
    public void OpenInstruction()
    {
        Time.timeScale = 0;
        input.EnableInstructionInput();
        input.DisableGameplayInput();
        instruction.SetActive(true);
    }
    public void AddForce(Vector2 force)
    {
        rb.AddForce(force * flipX, ForceMode2D.Impulse);
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
    public void Move(float speed)
    {
        if (input.Move)
        {
            transform.localScale = new Vector3(input.AxisX, 1f, 1f);
        }
        SetVelocityX(speed * input.AxisX);
    }
    public void SetUseGravity(bool value)
    {
        rb.gravityScale = value ? 1f : 0f;
    }
    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Monster") || other.gameObject.CompareTag("BossAttack") ||
        other.gameObject.CompareTag("Bullet") && this.tag == "Player")
        {
            // Debug.Log("OnTriggerStay2D");
            if (other.transform.position.x > transform.position.x)
            {
                dir = 1f;
            }
            else
            {
                dir = -1f;
            }
            if (!canBeAttack) return;
            rb.AddForce(new Vector2(-5 * dir, 0), ForceMode2D.Impulse);
            // if (canBeAttack)
            // {

            player.TakeDamage(2);
            canBeAttack = false;
            // StartCoroutine("BeAttackTimer");

            StartCoroutine(BeAttackTimer(beAttackTime));
            StartCoroutine(FlashColor(flashTimer));
            // }
            beAttack = true;


        }
    }
    IEnumerator FlashColor(float time)
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(time);
        spriteRenderer.color = originColor;
    }
    IEnumerator BeAttackTimer(float time)
    {
        yield return new WaitForSeconds(time);
        canBeAttack = true;
        // boxCollider.enabled = true;


    }
    // private void OnTriggerEnter2D(Collider2D other) {
    //     if (other.gameObject.CompareTag("Monster"))

    //     {
    //         Debug.Log("OnTriggerEnter2D");

    //         if (canBeAttack)
    //         {
    //             TakeDamage(2);
    //             beAttack = true;

    //         }

    //     }
    // }
}
