using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    private bool storeInRange;
    private bool cropFieldInRange;
    private void interaction(InputAction.CallbackContext context)
    {
        if (cropFieldInRange)
        {
            ActionCrop();
        }
        else if (storeInRange)
        {
            ActionSell();
        }
    }

    protected virtual void ActionCrop()
    {

    }
    protected virtual void ActionSell() 
    { 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Store"))
        {
            storeInRange = true;
        }
        else if (other.CompareTag("CropField"))
        {
            cropFieldInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Store"))
        {
            storeInRange = false;
        }
        else if (other.CompareTag("CropField"))
        {
            cropFieldInRange = false;
        }
    }
}
