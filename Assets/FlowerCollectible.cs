using UnityEngine;

public class FlowerCollectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddFlower();
            Destroy(gameObject);
        }
    }
}