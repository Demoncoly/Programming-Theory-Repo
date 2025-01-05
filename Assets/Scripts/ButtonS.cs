using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonS : MonoBehaviour
{
    public GameObject carCharacter;
    public GameObject personCharacter;
    public void Awake()
    {
        if (Menu.Instance.characterSelected == 2)
        {
            carCharacter.SetActive(true);
        }
        if (Menu.Instance.characterSelected == 1)
        {
            personCharacter.SetActive(true);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
public void SelectCar()
    {
        Menu.Instance.characterSelected = 2;
    }
public void SelectPerson()
    {
        Menu.Instance.characterSelected = 1;
    }
    public void MainMenu() 
    {
        SceneManager.LoadScene(0);
    }
}
