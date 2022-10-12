using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private SoundManager soundManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball_Count"))
        {
            gameManager.BallCount();
            soundManager.BallHitSound();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            soundManager.BallHitSound();
        }
    }
}