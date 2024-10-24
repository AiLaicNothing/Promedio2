using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : CropField
{
    [SerializeField] protected string name;
    [SerializeField] private GameObject PrefabCrop;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void SpawnCrop()
    {
        //Spawn the crop
        //Instantiate(PrefabCrop,CropPos);
    }
}
