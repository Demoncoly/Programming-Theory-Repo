using TMPro;
using UnityEngine;

public class scorecounter : MonoBehaviour
{
    public TextMeshProUGUI greyCounter;
    public TextMeshProUGUI goldCounter;
    public TextMeshProUGUI greenCounter;
    private void Update()
    {
        greyCounter.text = $"Grey collected : {Menu.Instance.greyScore}";
        goldCounter.text = $"Gold collected : {Menu.Instance.goldScore}";
        greenCounter.text = $"Green collected : {Menu.Instance.greenScore}";
    }
}

