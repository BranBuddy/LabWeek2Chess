using UnityEngine;
[ExecuteInEditMode]
public class ChessBoard : MonoBehaviour
{
    [SerializeField] private Vector3[] boardOutline;
    void Start()
    {
        boardOutline = new Vector3[4]
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 8, 0),
            new Vector3(8, 8, 0),
            new Vector3 (8, 0, 0),
        };
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLineStrip(boardOutline, true);


        for (int i = 0; i < 8; i++) {
            Vector3 end = new Vector3(0, i, 0);
            Vector3 start = new Vector3(8, i, 0);
            Gizmos.color = Color.red;
            Gizmos.DrawLine(start, end);
        }

        for (int i = 0; i < 8; i++)
        {
            Vector3 end = new Vector3(i, 0, 0);
            Vector3 start = new Vector3(i, 8, 0);
            Gizmos.color = Color.red;
            Gizmos.DrawLine(start, end);
        }
    }
}
