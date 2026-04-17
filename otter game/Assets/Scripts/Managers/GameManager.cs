using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int materialSelected;
    
    public static GameManager Instance;
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

    public void ActualMaterial(int materialID)
    {
        
    }
}
