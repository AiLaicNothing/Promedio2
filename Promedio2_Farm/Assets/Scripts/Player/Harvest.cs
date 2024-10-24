using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Harvest : MonoBehaviour
{
    private bool cropFieldInRange = false;
    private CropField currentCropField;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dirt"))
        {
            cropFieldInRange = true;
            currentCropField = other.GetComponent<CropField>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dirt"))
        {
            cropFieldInRange = false;
            currentCropField = null;
        }
    }

    public void Action(InputAction.CallbackContext context)
    {

        if (cropFieldInRange) 
        {;
            currentCropField.PlantCrop();
        }
    }
}
