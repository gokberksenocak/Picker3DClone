using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CustomInspector)), CanEditMultipleObjects]
public class LevelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CustomInspector _examp = (CustomInspector)target;

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Create Ball")) {_examp.CreateBall();}
        if (GUILayout.Button("Delete Ball")) {_examp.DeleteBall();}
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Create Palet Item")) {_examp.CreatePaletItem();}
        if (GUILayout.Button("Delete Palet Item")) {_examp.DeletePaletItem();}
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Create BonusBall Item")) { _examp.CreateBonusBall();}
        if (GUILayout.Button("Delete BonusBall Item")) { _examp.DeleteBonusBall();}
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Create Plus5 Item")) { _examp.CreatePlus5();}
        if (GUILayout.Button("Delete Plus5 Item")) { _examp.DeletePlus5();}
        EditorGUILayout.EndHorizontal();

        if (GUILayout.Button("Go to Level 1")) { _examp.Lev1(); }
        if (GUILayout.Button("Go to Level 2")) { _examp.Lev2();}
        if (GUILayout.Button("Go to Level 3")) { _examp.Lev3(); }
        if (GUILayout.Button("Go to Level 4")) { _examp.Lev4(); }
        if (GUILayout.Button("Go to Level 5")) { _examp.Lev5(); }
        if (GUILayout.Button("Go to Level 6")) { _examp.Lev6(); }
        if (GUILayout.Button("Go to Level 7")) { _examp.Lev7(); }
        if (GUILayout.Button("Go to Level 8")) { _examp.Lev8(); }
        if (GUILayout.Button("Go to Level 9")) { _examp.Lev9(); }
        if (GUILayout.Button("Go to Level 10")) { _examp.Lev10(); }
        if (GUILayout.Button("Add New Level Scene")) { _examp.CreateNewLevel();}
    }
}