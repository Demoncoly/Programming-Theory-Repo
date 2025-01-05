using UnityEngine;

public class Menu : MonoBehaviour
{
    public static Menu Instance;
    public int characterSelected;
    public float greyScore;
    public int goldScore;
    public int greenScore;

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
