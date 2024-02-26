using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CraftingRecipe : MonoBehaviour
{
    public Dictionary<string, Slot> craftingItems = new Dictionary<string, Slot>();
    public CraftingSlot A;
    public CraftingSlot B;
    public CraftingSlot C;
    public Dictionary<string, Item> recipe;
    [System.Serializable]
    public struct RecipeStruct
    {
        public Item A;
        public Item B;
        public Item result;
    }
    public RecipeStruct[] recipeStructs;
    private void Awake()
    {
        recipe = new Dictionary<string, Item>();
        for (int i = 0; i < recipeStructs.Length; i++)
        {
            recipe.Add(recipeStructs[i].A.itemName + recipeStructs[i].B.itemName, recipeStructs[i].result);
            recipe.Add(recipeStructs[i].B.itemName + recipeStructs[i].A.itemName, recipeStructs[i].result);
        }
    }
    public void ComposeItem()
    {
        InventoryManager.ComposeItem(craftingItems["A"], craftingItems["B"]);
    }
}
