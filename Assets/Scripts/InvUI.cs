using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvUI : MonoBehaviour
{
    private TextMeshProUGUI FlowerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FlowerText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateFlowerText(PlayerInv playerInv)
    {
        FlowerText.text = playerInv.NumberOfFlowers.ToString();
    }
}
