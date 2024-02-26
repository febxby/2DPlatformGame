using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item item;
    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = item.image;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // this.gameObject.SetActive(false);
            InventoryManager.AddNewItem(item);
            ObjectPool.Instance.PushObject(this.gameObject);
        }
    }


}
