using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryStructure", menuName = "Scriptable Objects/InventoryStructure")]
public class InventoryStructure : ScriptableObject
{
    public List<BaseMath> Hotbar;
}
