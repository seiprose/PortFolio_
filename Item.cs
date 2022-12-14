using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Used,
        Key
    }

    public GameObject itemPrefab;
    public string itemName;
    public Sprite itemImage;
    public int itemNum;
}
