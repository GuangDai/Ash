using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 物品的基类
/// </summary>

public class Item : MonoBehaviour {
    public int ID { get; set; }
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public ItemQuality Quality { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public int BuyPrice { get; set; }
    public int SellPrice { get; set; }
    public string Sprite { get; set; }

    public Item(){

    }

    public Item (
        int id, 
        string name, 
        ItemType type, 
        ItemQuality quality,
        string description,
        int capacity,
        int buyPrice,
        int sellPrice,
        string sprite
        )
        {
        this.ID = id;
        this.Name = name;
        this.Type = type;
        this.Quality = quality;
        this.Description = description;
        this.Capacity = capacity;
        this.BuyPrice = buyPrice;
        this.SellPrice = sellPrice;
        this.Sprite = sprite;
    }
/// <summary>
/// 物品的类别
/// </summary>
    public enum ItemType{
        Consumable,
        Equipment,
        Material,
        Task
    }
/// <summary>
/// 物品的品质
/// </summary>
    public enum ItemQuality{
        Common,
        Rare,
        Epic,
        Legendary
    }

}