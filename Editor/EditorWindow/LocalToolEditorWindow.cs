using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LocalToolEditorWindow : EditorWindow
{

    public const float windowSize = 500f;
    [MenuItem("本地工具.../批量工具")]
    public static void OpenWindow()
    {
        
        LocalToolEditorWindow editorWindow = GetWindow<LocalToolEditorWindow>();
        if (editorWindow != null)
        {
            Vector2 initSize = new Vector2(500f, 500f);
            editorWindow.position = new Rect(new Vector2(Screen.currentResolution.width/2f- windowSize/2f,
                                                       Screen.currentResolution.height/2f- windowSize/2f),
                                                       initSize);
            editorWindow.Show();
        }
    }

     void OnGUI()
    {
        
    }


}
