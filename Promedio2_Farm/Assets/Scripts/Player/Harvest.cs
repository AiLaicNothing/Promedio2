using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Harvest : Interaction
{
    private Inventory inventory;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    protected override void ActionCrop()
    {
        if (CurrentCropField == null)
        {
            Debug.LogWarning("CurrentCropField is null");
            return;
        }

        if (!CurrentCropField.hasCrop)
        {
            Debug.Log("Planting crop");
            CurrentCropField.PlantCrop();
        }
        else if (CurrentCropField.hasCrop && CurrentCropField.cropHasGrown)
        {
            Debug.Log("Harvesting crop");
            HarvestCrop();
        }
    }

    private void HarvestCrop()
    {
        CurrentCropField.DeletecCrop();
        inventory.Crops += 1;
    }
}
