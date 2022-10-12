using UnityEngine;

public class Palets : MonoBehaviour
{
    private bool waited = false;
    [SerializeField] private float RotateSpeed;
    void Start()
    {
        Invoke("Delay_Rotation", .3f);
    }
    void Update()
    {
        if (waited)
        {
            transform.Rotate(0f, 0f, RotateSpeed * Time.deltaTime, Space.Self);
        }
    }
    void Delay_Rotation()
    {
        waited = true;
    }
}