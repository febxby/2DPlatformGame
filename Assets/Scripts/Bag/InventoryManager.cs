using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// [System.Serializable]
// public class Items
// {

// }
public class InventoryManager : MonoBehaviour
{
    // [SerializeField] public Dictionary<Item, int> items = new Dictionary<Item, int>();
    [SerializeField] List<Items> items;
    [SerializeField] List<Item> itemList;
    [SerializeField] EquipManager equipManager;
    static InventoryManager instance;


    public Inventory myBag;
    public List<GameObject> craftingSlotGrid;
    public GameObject slotGrid;
    public CraftingSlot craftingSlotPrefab;
    public Slot slotPrefab;
    public Text itemInformation;
    public RectTransform content;
    public CraftingRecipe craftingRecipe;

    private Slot isSelected = null;

    private int colNumber;
    private int itemHeight;
    private int spacing;
    List<Items> temp;
    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
        colNumber = content.GetComponent<GridLayoutGroup>().constraintCount;
        itemHeight = (int)content.GetComponent<GridLayoutGroup>().cellSize.y;
        spacing = (int)content.GetComponent<GridLayoutGroup>().spacing.y;
        temp = SaveSystem.LoadListFromJson<Items>("Inventory");
        if (temp != default(List<Items>))
            items = temp;
        else
            items = new List<Items>();
    }
    private void OnDestroy()
    {
        SaveItems();
    }
    private void OnEnable()
    {

        RefreshItem();
        instance.itemInformation.text = "";

    }
    public static void SaveItems()
    {
        SaveSystem.SaveByJson("Inventory", new SerializationList<Items>(instance.items));
        // string json = JsonUtility.ToJson(new SerializationList<Items>(instance.items));
        // Debug.Log(json);

    }
    public static int FindItem(Item item)
    {
        return instance.items.FindIndex(x => x.item.Equals(item));
    }
    public static void UpdateItemInfo(Slot slot)
    {
        instance.isSelected = slot;
        instance.itemInformation.text = slot.slotItem.description;
    }
    public static void EquipItem(Item item)
    {
        instance.equipManager.EquipItem(item);
    }
    public static void AddCraftingItem(CraftingSlot item)
    {
        if (instance.isSelected == null)
            return;
        item.GetComponent<Image>().sprite = instance.isSelected.slotItem.image;
        // if (!instance.craftingRecipe.craftingItems.ContainsKey(item.gameObject.name))
        //     instance.craftingRecipe.craftingItems.Add(item.gameObject.name, instance.isSelected);
        // else
        instance.craftingRecipe.craftingItems[item.gameObject.name] = instance.isSelected;
        instance.isSelected = null;
    }
    public static void ComposeItem(Slot A, Slot B)
    {
        if (!A || !B)
            return;
        if (instance.craftingRecipe.recipe.TryGetValue(A.slotItem.itemName + B.slotItem.itemName, out Item result))
        {
            instance.items.Find(x => x.item == A.slotItem).count--;
            instance.items.Find(x => x.item == B.slotItem).count--;
            // instance.myBag.items[A.slotItem]--;
            // instance.myBag.items[B.slotItem]--;
            // A.slotItem.count--;
            // B.slotItem.count--;

            AddNewItem(result);

            instance.craftingRecipe.C.GetComponent<Image>().sprite = result.image;
            instance.craftingRecipe.A.GetComponent<Image>().sprite = null;
            instance.craftingRecipe.B.GetComponent<Image>().sprite = null;
            RefreshItem();
        }
        else
        {
            Debug.Log("No recipe");
        }
    }
    public static int DecreaseItem(Item item)
    {
        int index = FindItem(item);
        if (index != -1)
        {
            if (instance.items[index].count > 0)
            {
                instance.items[index].count--;
            }
        }
        RefreshItem();
        return instance.items[index].count;
    }
    public static void AddNewItem(Item item)
    {
        int index = FindItem(item);
        if (index != -1)
        {
            if (instance.items[index].count < 99)
            {
                // item.count++;
                instance.items[index].count++;
            }
        }
        else
        {
            instance.items.Add(new Items() { item = item, name = item.name, count = 1 });
            AddPreafb(item);
        }
        RefreshItem();
    }
    public static void AddPreafb(Item item)
    {

        Slot newItem = Instantiate(instance.slotPrefab,
        instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.image;
        newItem.slotCount.text = instance.items[FindItem(item)].count.ToString();
    }
    public static void RefreshItem()
    {
        int h = (Mathf.CeilToInt(instance.items.Count / (float)instance.colNumber) * (instance.itemHeight + instance.spacing));
        instance.content.sizeDelta = new Vector2(0, h);
        instance.content.anchoredPosition = new Vector2(instance.content.anchoredPosition.x, -h / 2);
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        foreach (Items item in instance.items)
        {
            if (item.count <= 0)
                continue;
            AddPreafb(instance.itemList.Find(x => x.itemName == item.name));
        }
        // for (int i = 0; i < instance.myBag.items.Count; i++)
        // {
        //     if (instance.myBag.items. <= 0)
        //         continue;
        //     AddPreafb(instance.myBag.items[i]);
        // }
    }
}
