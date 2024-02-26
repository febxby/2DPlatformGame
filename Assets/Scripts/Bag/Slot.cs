using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
[System.Serializable]
public class EquipEvent : UnityEvent<Item> { }
public class Slot : MonoBehaviour, IPointerClickHandler
{
    public Item slotItem;
    public Image slotImage;
    public Text slotCount;
    public EquipEvent rightClickEvent;
    public void ItemOnClicked()
    {
        InventoryManager.UpdateItemInfo(this);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            InventoryManager.EquipItem(slotItem);
        }
    }
}
