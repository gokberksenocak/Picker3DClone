using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FrontCheck"))
        {
            gameManager.Checkpoint();
        }
    }
}
