using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioViewEditor : EditorWindow
{
   [MenuItem("Tool/Audio")]
   static void CreateWindow()
   {
      Rect rect =new Rect(400,400,100,100);

      //AudioViewEditor audioView = EditorWindow.GetWindowWithRect(typeof(AudioViewEditor),rect) as AudioViewEditor;
      AudioViewEditor audioView = EditorWindow.GetWindow<AudioViewEditor>("音效管理器");
      audioView.Show();
   }


   private string text;
   private void OnGUI()
   {
      EditorGUILayout.TextField("输入文字:", text);
   }
}
