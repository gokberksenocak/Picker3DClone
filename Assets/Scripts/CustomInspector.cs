using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class CustomInspector : MonoBehaviour
{
    [SerializeField] private Vector3 spawn_position;
    [SerializeField] private Vector3 RotationValues;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject palet_item;
    [SerializeField] private GameObject bonusball_item;
    [SerializeField] private GameObject plus5_item;
    private List<GameObject> balls = new List<GameObject>();
    private List<GameObject> palet_items = new List<GameObject>();
    private List<GameObject> bonusball_items = new List<GameObject>();
    private List<GameObject> plus5_items = new List<GameObject>();

    public void Lev1() { EditorSceneManager.OpenScene("Assets/Scenes/Level1.unity"); }
    public void Lev2() { EditorSceneManager.OpenScene("Assets/Scenes/Level2.unity"); }
    public void Lev3() { EditorSceneManager.OpenScene("Assets/Scenes/Level3.unity"); }
    public void Lev4() { EditorSceneManager.OpenScene("Assets/Scenes/Level4.unity"); }
    public void Lev5() { EditorSceneManager.OpenScene("Assets/Scenes/Level5.unity"); }
    public void Lev6() { EditorSceneManager.OpenScene("Assets/Scenes/Level6.unity"); }
    public void Lev7() { EditorSceneManager.OpenScene("Assets/Scenes/Level7.unity"); }
    public void Lev8() { EditorSceneManager.OpenScene("Assets/Scenes/Level8.unity"); }
    public void Lev9() { EditorSceneManager.OpenScene("Assets/Scenes/Level9.unity"); }
    public void Lev10() { EditorSceneManager.OpenScene("Assets/Scenes/Level10.unity"); }
    public void CreateNewLevel() {EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Additive); }
    public void CreateBall() {balls.Add(Instantiate(ball, spawn_position, Quaternion.Euler(RotationValues)));}
    public void DeleteBall()
    {
        DestroyImmediate(balls[balls.Count - 1]);
        balls.RemoveAt(balls.Count - 1);
    }
    public void CreatePaletItem() { palet_items.Add(Instantiate(palet_item, spawn_position, Quaternion.Euler(RotationValues))); }
    public void DeletePaletItem()
    {
        DestroyImmediate(palet_items[palet_items.Count - 1]);
        palet_items.RemoveAt(palet_items.Count - 1);
    }
    public void CreateBonusBall() { bonusball_items.Add(Instantiate(bonusball_item, spawn_position, Quaternion.Euler(RotationValues))); }
    public void DeleteBonusBall()
    {
        DestroyImmediate(bonusball_items[bonusball_items.Count - 1]);
        bonusball_items.RemoveAt(bonusball_items.Count - 1);
    }
    public void CreatePlus5() { plus5_items.Add(Instantiate(plus5_item, spawn_position, Quaternion.Euler(RotationValues))); }
    public void DeletePlus5()
    {
        DestroyImmediate(plus5_items[plus5_items.Count - 1]);
        plus5_items.RemoveAt(plus5_items.Count - 1);
    }
}