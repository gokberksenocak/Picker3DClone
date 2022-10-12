using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 90 * Time.deltaTime, Space.World);
    }
}
