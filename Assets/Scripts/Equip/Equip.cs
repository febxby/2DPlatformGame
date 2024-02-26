using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : ScriptableObject, IEquip
{
    protected Player player;
    protected PlayerInput playerInput;
    protected PlayerController playerController;
    protected EquipManager equipManager;
    public float coolDownTime;
    [HideInInspector]
    public bool isCoolDown = true;
    public virtual void Use()
    {
    }
    public void Initialize(Player player, PlayerInput playerInput, PlayerController playerController, EquipManager equipManager)
    {
        this.player = player;
        this.playerInput = playerInput;
        this.playerController = playerController;
        this.equipManager = equipManager;
    }
}
