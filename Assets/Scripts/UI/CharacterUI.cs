using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    public Image equipment;
    public Image healthBar;
    public Image magicBar;
    public Image delayBar;
    public void Init(float health, float magic)
    {
        if (healthBar != null)
            healthBar.fillAmount = health;
        if (magicBar != null)
            magicBar.fillAmount = magic;
    }
    public void UpdateHealthBar(float health)
    {
        if (healthBar != null)
            healthBar.fillAmount = health;

    }
    public void UpdateMagicBar(float magic)
    {
        if (magicBar != null)
            magicBar.fillAmount = magic;
    }
    private void Update()
    {
        if (delayBar != null)
        {
            if (delayBar.fillAmount > healthBar.fillAmount)
            {
                delayBar.fillAmount -= Time.deltaTime;
            }
        }
    }
    public void UpdateEquipment(Item item)
    {
        if (item != null)
        {
            equipment.sprite = item.image;
            equipment.color = Color.white;
        }
        else
        {
            equipment.color = Color.clear;
        }
    }
}
