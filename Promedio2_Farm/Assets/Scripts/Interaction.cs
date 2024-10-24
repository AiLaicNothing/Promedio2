using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    private bool storeInRange;
    private bool cropFieldInRange;

    protected CropField CurrentCropField;
    public void interaction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (cropFieldInRange)
            {
                ActionCrop();
            }
            else if (storeInRange)
            {
                Debug.Log("SEll");
                ActionSell();
            }
        }
        //if (cropFieldInRange)
        //{
        //    ActionCrop();
        //}
        //else if (storeInRange)
        //{
        //    ActionSell();
        //}
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
            CurrentCropField = other.GetComponent<CropField>();
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
            CurrentCropField = null;

        }
    }
}
