using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(ChessPiece))]
public class DrawOutline : Editor
{
    void OnSceneGUI()
    {
        Handles.color = Color.yellow;

        ChessPiece t = target as ChessPiece;

        if (t != null || t.GameObjects == null)
        {
            return;
        }

        Vector3 center = t.transform.position;

        for (int i = 0; i < t.GameObjects.Length; i++)
        {

            if (t.GameObjects[i] != null)
            {
                Handles.DrawLine(center, t.GameObjects[i].transform.position);
            }

        }
    }
}
