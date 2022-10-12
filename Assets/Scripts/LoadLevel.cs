using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void Loading()
    {
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 1);
            SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
        }
        else
        {
            if (PlayerPrefs.GetInt("level") <= 10)
            {
                SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
            }
            else
            {
                SceneManager.LoadScene(PlayerPrefs.GetInt("RandomLevelIndex"));
            }
        }
    }
}
