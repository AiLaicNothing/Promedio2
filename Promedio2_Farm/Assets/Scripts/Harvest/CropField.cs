using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropField : MonoBehaviour
{
    [SerializeField] protected Transform cropPos; // Position to place the crop
    [SerializeField] private GameObject cropPrefab; // Prefab of the crop to grow
    [SerializeField] private GameObject unGrowPrefab; // Prefab for the initial state of the crop
    private bool hasCrop = false;

    private bool cropHasGrown = false;

    [SerializeField] private float timeToGrow; // Time in seconds for the crop to grow
    private float timer;

    private GameObject currentUnGrowInstance; // Track the instantiated unGrowPrefab

    private void Update()
    {
        if (hasCrop)
        {
            GrowCrop();
        }
    }

    public void PlantCrop()
    {
        if (!hasCrop)
        {
            hasCrop = true;
            timer = 0f; // Reset the timer
            // Instantiate the initial (ungrown) crop visual
            currentUnGrowInstance = Instantiate(unGrowPrefab, cropPos.position, Quaternion.identity);
            cropHasGrown = false;
        }
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
            // Give crop to player and replace the ungrown crop
            SpawnCrop();
            Destroy(currentUnGrowInstance); // Destroy the ungrown crop instance
            Instantiate(cropPrefab, cropPos.position, Quaternion.identity); // Spawn the grown crop
            cropHasGrown = true;
            hasCrop = false; // Reset the crop field
        }
    }

    protected virtual void SpawnCrop()
    {
        // Implement the logic to give the crop to the player
        // Example: PlayerInventory.Add(cropPrefab);
    }
}
