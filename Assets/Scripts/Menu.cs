using UnityEngine;

public class Menu : MonoBehaviour
{
    public static Menu Instance;
    public int characterSelected;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
