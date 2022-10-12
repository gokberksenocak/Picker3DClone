using UnityEngine;

public class Picker : MonoBehaviour
{
    private Vector3 diff;
    private Vector3 PickerPosX;
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item_palet"))
        {
            other.gameObject.SetActive(false);
            gameManager.Palets_Active();
        }
        if (other.gameObject.CompareTag("item_ball"))
        {
            other.gameObject.SetActive(false);
            gameManager.ExtraBalls();
        }
        if (other.gameObject.CompareTag("item_plus5"))
        {
            other.gameObject.SetActive(false);
            gameManager.BallCountPlus5();
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            gameManager.LevelWon();
        }
    }
    void FixedUpdate()
    {
        Picker_Moving();
    }
    private void Picker_Moving()
    {
        if (gameManager.picker_ismoving)
        {
            transform.position += transform.forward * gameManager.picker_speed * Time.deltaTime / 1.25f;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z), 0.4f);

            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z), 0.4f);
            }
        }
        gameManager.image_progressBar.fillAmount = (88 - (64 - transform.position.z)) / 88;// [bütün yol-(son nokta-mevcut nokta)] / %88deki oranı
    }
}