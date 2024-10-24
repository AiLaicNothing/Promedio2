using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropField : MonoBehaviour
{
    [SerializeField] protected Transform cropPos; // Position to place the crop
    [SerializeField] private GameObject cropPrefab; // Prefab of the crop to grow
    [SerializeField] private GameObject unGrowPrefab; // Prefab for the initial state of the crop
    public bool hasCrop = false;

    public bool cropHasGrown = false;

    [SerializeField] private float timeToGrow; // Time in seconds for the crop to grow
    private float timer;

    private GameObject currentUnGrowInstance; // Track the instantiated unGrowPrefab
    private GameObject currentCropInstance;

    private void Update()
    {
        if (hasCrop && cropHasGrown == false)
        {
            GrowCrop();
        }
    }

    public void PlantCrop()
    {
            timer = 0f; // Reset the timer
            // Instantiate the initial (ungrown) crop visual
            hasCrop = true;
            currentUnGrowInstance = Instantiate(unGrowPrefab, cropPos.position, Quaternion.identity);
            cropHasGrown = false;
    }

    private void GrowCrop()
    {
        if (timer < timeToGrow)
        {
            timer += Time.deltaTime;
            // Update the ungrown crop state here if needed
        }

        if (timer >= timeToGrow)
        {
            Destroy(currentUnGrowInstance); // Destroy the ungrown crop instance
            currentCropInstance = Instantiate(cropPrefab, cropPos.position, Quaternion.identity); // Spawn the grown crop
            cropHasGrown = true;
            hasCrop = true; // Reset the crop field
        }
    }

    public void DeletecCrop()
    {
        Destroy(currentCropInstance);
        cropHasGrown = false ;
        hasCrop = false ;
    }
}
