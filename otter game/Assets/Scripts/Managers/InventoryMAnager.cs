using System.Collections.Generic;
using UnityEngine;

public class InventoryMAnager : MonoBehaviour
{
    [SerializeField] private List<ScriptableObject> Inventory;
    public InventoryStructure inventoryStructure;
    public BaseMaterial temp;

    public static InventoryMAnager Instance;

    private void Awake()
    {
        AddToInventory(temp, 10);
        // singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Update()
    {
 
    }
    public void AddToInventory(BaseMaterial newMat, int amount)
    {
        newMat.MaterialAmount = newMat.MaterialAmount + amount;
    }
    public void RemoveFromInventory(BaseMaterial oldMath, int amount) 
    {
    
    }
}
