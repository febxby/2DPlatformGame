using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipManager : MonoBehaviour
{
    [SerializeField] Equip[] equips;
    Dictionary<System.Type, Equip> equipTable;
    public Equip currentEquip;
    Item item;
    [SerializeField] CharacterUI characterUI;
    public PlayerAttack playerAttack;
    Player player;
    PlayerInput playerInput;
    PlayerController playerController;
    public Transform firePos;
    // Start is called before the first frame update
    void Awake()
    {
        playerAttack = GetComponentInChildren<PlayerAttack>();
        playerInput = GetComponent<PlayerInput>();
        playerController = GetComponent<PlayerController>();
        player = GetComponent<Player>();
        equipTable = new Dictionary<System.Type, Equip>(equips.Length);
        foreach (Equip equip in equips)
        {
            equip.Initialize(player, playerInput, playerController, this);
            equipTable.Add(equip.GetType(), equip);
        }
    }
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        characterUI.UpdateEquipment(item);

        if (playerInput.isUseItem)
        {
            if (currentEquip == null)
            {
                return;
            }
            currentEquip.Use();
            if (currentEquip == equipTable[typeof(RestorePower)])
            {
                if (InventoryManager.DecreaseItem(item) <= 0)
                {
                    item = null;
                    currentEquip = null;
                }
            }
            else
            {
                if (currentEquip.isCoolDown)
                    StartCoroutine(CoolDown(currentEquip.coolDownTime));
            }
        }
    }
    IEnumerator CoolDown(float coolDownTime)
    {
        currentEquip.isCoolDown = false;

        yield return new WaitForSeconds(coolDownTime);
        currentEquip.isCoolDown = true;
    }
    public void EquipItem(Item item)
    {
        switch (item.id)
        {
            case 0:
                currentEquip = equipTable[typeof(Sword)];
                break;
            case 1:
                currentEquip = equipTable[typeof(Gun)];
                break;
            case 2:
                currentEquip = equipTable[typeof(RestorePower)];
                break;
            default:
                currentEquip = null;
                item = null;
                break;
        }
        this.item = item;
        // currentEquip?.Initialize(player, playerInput, playerController, this);
        // Debug.Log("EquipItem");
    }
}
