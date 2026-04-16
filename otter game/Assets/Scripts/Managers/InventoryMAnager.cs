using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventoryStructure inventoryStructure;
    public static InventoryManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateHotbar();
    }

    private void Update()
    {
        
    }
    public void AddToInventory(int itemID, int itemAmount)
    {
        UpdateHotbar();
    }
    public void RemoveFromInventory(int itemID, int itemAmount) 
    {
        UpdateHotbar();
    }

    private void UpdateHotbar()
    {
        UIManager.Instance.UpdateHotbar();
    }
}