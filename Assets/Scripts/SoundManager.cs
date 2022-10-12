using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] sounds;
    [SerializeField] private AudioSource audioSource;
    
    public void BallHitSound() { AudioSource.PlayClipAtPoint(sounds[0], transform.position); }
    public void CheckpointSound() { audioSource.PlayOneShot(sounds[1]); }
    public void FailSound() { audioSource.PlayOneShot(sounds[2]); }
    public void ItemSound() { audioSource.PlayOneShot(sounds[3]); }
    public void WonSound() { audioSource.PlayOneShot(sounds[4]); }

}