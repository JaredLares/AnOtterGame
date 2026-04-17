using UnityEngine;

public class hotbarItem : MonoBehaviour
{
    [SerializeField] private int currentItemID;

    public void saveID(int newID)
    {
        currentItemID = newID;
    }

}
