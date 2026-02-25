using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int flowerCount = 0;
    public TextMeshProUGUI flowerText;

    private void Awake()
    {
        instance = this;
    }

    public void AddFlower()
    {
        flowerCount++;
        flowerText.text = "Flowers: " + flowerCount;
    }
}