using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIValue : MonoBehaviour
{
    private Inventory inventory;

    [SerializeField] private TextMeshProUGUI money;
    [SerializeField] private TextMeshProUGUI crops;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        SetValue();
    }

    private void SetValue()
    {
        money.text = $"Money:{inventory.Money}";
        crops.text = $"Crops:{inventory.Crops}";
    }
}
