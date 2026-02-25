using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInv : MonoBehaviour
{
    public int NumberOfFlowers {  get; private set; }

    public UnityEvent<PlayerInv> OnFlowerCollected;
    public void FlowerCollected()
    {
        NumberOfFlowers++;
        OnFlowerCollected.Invoke(this);
    }
}
