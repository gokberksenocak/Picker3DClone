using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[Serializable]
public class LevelEdit
{
    public int ball_need;//platformu basariyla gecebilmek icin toplanilmasi gereken top miktari.
    public Animator elevator_animator;
    public TextMeshProUGUI ballCount_text;
    public GameObject[] balls;
}
public class GameManager : MonoBehaviour
{
    [Header("LEVEL OBJECTS")]
    [SerializeField] private GameObject Picker;
    [SerializeField] private GameObject Palets;
    [SerializeField] private GameObject BonusBalls;
    [SerializeField] private Transform BallCountArea;

    [Header("UI OBJECTS")]
    public Image image_progressBar;
    public GameObject FailPanel;
    [SerializeField] private GameObject StartPanel;
    [SerializeField] private GameObject WonPanel;
    [SerializeField] private TextMeshProUGUI text_currentLevel;
    [SerializeField] private TextMeshProUGUI text_nextLevel;
    [SerializeField] private GameObject Plus5CountText;//ilgili item alindiginda ekranda gozukecek olan text

    [Header("OTHER OBJECTS SCRIPTS")]
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private AdManager adManager;

    [Header("VARIABLES")]
    public bool picker_ismoving = false;
    public int ball_drop;//platform sonunda asansore basariyla dusurulen top sayisi
    public float picker_speed = 4f;
    public int CheckPointIndex = 0;
    private int CheckPointTotal;
    private bool item_taken = false;

    [Header("LEVEL EDIT")]
    public List<LevelEdit> _LevelEdit = new List<LevelEdit>();//en ustteki classi liste haline getirip kullanacagiz.
    private Scene _scene;

    void Start()
    {
        _scene = SceneManager.GetActiveScene();
        text_currentLevel.text = PlayerPrefs.GetInt("level").ToString();
        text_nextLevel.text = (PlayerPrefs.GetInt("level") + 1).ToString();
    }
    public void TaptoStart()
    {
        StartPanel.SetActive(false);
        picker_ismoving = true;
        for (int i = 0; i < _LevelEdit.Count; i++)
        {
            _LevelEdit[i].ballCount_text.text = ball_drop + "/" + _LevelEdit[i].ball_need;//asansor texti ayarlandi
        }
        CheckPointTotal = _LevelEdit.Count - 1;//index durumu, 0dan basladigi icin count -1 dedik
    }
    public void Palets_Active()
    {
        soundManager.ItemSound();
        Palets.SetActive(true);
        item_taken = true;
    }
    public void ExtraBalls()
    {
        soundManager.ItemSound();
        BonusBalls.SetActive(true);
        item_taken = true;
    }
    public void BallCountPlus5()
    {
        soundManager.ItemSound();
        Plus5CountText.SetActive(true);
        ball_drop += 5;
        item_taken = true;
    }
    public void Checkpoint()//asansor sinirina gelindiginde calisir.
    {
        if (item_taken)
        {
            Palets.SetActive(false);
            Plus5CountText.SetActive(false);
            item_taken = false;
        }
        picker_ismoving = false;
        Collider[] hit_collider = Physics.OverlapBox(BallCountArea.position, BallCountArea.localScale / 2, Quaternion.identity);
        int k = 0;//pickerdaki collideri olan objelere guc uygulayarak iter
        while (k < hit_collider.Length)
        {
            if (hit_collider[k].GetComponent<Rigidbody>()!=null)
            {
                hit_collider[k].GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, .77f), ForceMode.Impulse);
            }
            k++;
        }
        Invoke("CountControl", 3f);
    }
    public void BallCount()//asansordeki sayim isini yapar.
    {
        ball_drop++;
        _LevelEdit[CheckPointIndex].ballCount_text.text = ball_drop + "/" + _LevelEdit[CheckPointIndex].ball_need;
    }
    public void CountControl()
    {
        if (ball_drop>= _LevelEdit[CheckPointIndex].ball_need)
        {
            _LevelEdit[CheckPointIndex].elevator_animator.Play("Elevator_ani");
            soundManager.CheckpointSound();
            BonusBalls.SetActive(false);
            for (int i = 0; i < _LevelEdit[CheckPointIndex].balls.Length; i++)
            {
                _LevelEdit[CheckPointIndex].balls[i].SetActive(false);
            }
            if (CheckPointIndex==CheckPointTotal)
            {
                if (picker_ismoving) { transform.Translate(Vector3.forward * Time.deltaTime); }
            }
            else
            {
                CheckPointIndex++;
                ball_drop = 0;//sonraki checkpointteki sayim isinin dogru calismasi icin yapildi.
            }  
        }
        else
        {
            FailPanel.SetActive(true);
            FailPanel.transform.DOMove(StartPanel.transform.position, .5f);
            soundManager.FailSound();
            BonusBalls.SetActive(false);
            for (int i = 0; i < _LevelEdit[CheckPointIndex].balls.Length; i++)
            {
                _LevelEdit[CheckPointIndex].balls[i].SetActive(false);
            }
        }
    }
    public void LevelWon()
    {
        picker_ismoving = false;
        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
        WonPanel.SetActive(true);
        WonPanel.transform.DOMove(StartPanel.transform.position, .5f);
        soundManager.WonSound();
    }
    public void SceneChanges(string grade)
    {
        if (grade=="fail")
        {
            SceneManager.LoadScene(_scene.buildIndex);
        }
        else
        {
            adManager.ShowInterstitial();
            Invoke(nameof(NextScene), .1f);
        }
    }
    public void NextScene()
    {
        if (PlayerPrefs.GetInt("level") <= 10)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
        }
        else
        {
            PlayerPrefs.SetInt("RandomLevelIndex", UnityEngine.Random.Range(1, 11));
            SceneManager.LoadScene(PlayerPrefs.GetInt("RandomLevelIndex"));
        }      
    }
}