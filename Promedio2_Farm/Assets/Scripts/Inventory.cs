using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private float money;
    [SerializeField] private float crops;
    // Start is called before the first frame update

    public float Money
    {
        get { return money; }
        set { money = value; }
    }

    public float Crops
    {
        get { return crops; }
        set { crops = value; }
    }

}
