using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 消耗品
/// </summary>

public class Consumable :Item  {
    public int Happy { get; set; }
    public int Drank { get; set; }

    public Consumable (
        int id, 
        string name, 
        ItemType type, 
        ItemQuality quality,
        string description,
        int capacity,
        int buyPrice,
        int sellPrice,
        string sprite,
        int happy,
        int drank
    ):base(id, name, type, quality, description, capacity, buyPrice, sellPrice, sprite)
    {
        this.Happy = happy;
        this.Drank = drank;
    }
}