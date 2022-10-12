using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject picker;
    private Vector3 diff;
    private Vector3 PickerPosX;
    void Update()
    {
        Picker_Bounds();
    }
    private void OnMouseDown()
    {
        diff = Input.mousePosition - Camera.main.WorldToScreenPoint(picker.transform.position);
    }
    private void OnMouseDrag()
    {
        PickerPosX = Camera.main.ScreenToWorldPoint(Input.mousePosition - diff);
        picker.transform.position = Vector3.Lerp(picker.transform.position, new Vector3(PickerPosX.x, picker.transform.position.y, picker.transform.position.z), Time.deltaTime * .45f);
    }
    private void Picker_Bounds()
    {
        Vector3 pos = picker.transform.position;
        pos.x = Mathf.Clamp(pos.x, -1.32f, 1.2f);
        picker.transform.position = pos;
    }
}
