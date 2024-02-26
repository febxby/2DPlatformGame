using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Data/Item")]
[System.Serializable]
public class Item : ScriptableObject
{
    [SerializeField]
    public int id;
    [SerializeField]
    public string itemName;
    [SerializeField]

    public Sprite image;
    [SerializeField]
    [TextArea]
    public string description;

}
