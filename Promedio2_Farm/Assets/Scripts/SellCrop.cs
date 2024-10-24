using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SellCrop : Interaction
{
    private Inventory inventory;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Sell()
    {
        if(inventory.Crops > 0)
        {
            inventory.Crops -= 1;
            inventory.Money += 1;
        }
    }

    protected override void ActionSell()
    {
        Sell();
    }
}
