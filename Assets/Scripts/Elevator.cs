using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Animator Barrier_ani;

    public void OpenBarrier()//elevator animasyonu bunu tetikledi, icindeki bariyer animasyonu da alttaki backtomove fonksiyonunu tetikleyecek.
    {
        Barrier_ani.Play("OpenBarrier");
    }
    public void BacktoMove()
    {
        gameManager.picker_ismoving = true;
    }
}
