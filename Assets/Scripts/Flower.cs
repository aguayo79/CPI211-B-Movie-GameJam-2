using UnityEngine;

public class Flower : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInv PlayerInv = other.GetComponent<PlayerInv>();

        if (PlayerInv != null )
        {
            PlayerInv.FlowerCollected();
            gameObject.SetActive(false);
        }
    }
}
