using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingSlot : MonoBehaviour
{
    public Item slotItem;
    public void ItemOnClicked(){
        InventoryManager.AddCraftingItem(this);
    }
}
