using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode]
public class ChessPiece : MonoBehaviour
{
    public Piece piece;

    public Sprite[] sprites;
    

    public Image image;

    public enum Piece
    {
        Pawn,
        Rook,
        Bishop,
        Knight,
        Queen,
        King
    }


    
    void Update()
    {
        SetChessPiece(); 

        image.transform.position = transform.position;
    }

    void SetChessPiece()
    {
        switch (piece)
        {
            case Piece.Pawn:
                image.sprite = sprites[0];
                break;
            case Piece.Rook:
                image.sprite = sprites[1];
                break;
            case Piece.Bishop:
                image.sprite = sprites[2];
                break;
            case Piece.Knight:
                image.sprite = sprites[3];
                break;
            case Piece.Queen:
                image.sprite = sprites[4];
                break;
            case Piece.King:
                image.sprite = sprites[5];
                break;
        }
    }

    private void OnDrawGizmosSelected()
    {
        switch (piece)
        {
            case Piece.Pawn:
                Vector3 up = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, up);
                break;
            case Piece.Rook:
                up = new Vector3(transform.position.x, transform.position.y + 7, transform.position.z);
                Vector3 down = new Vector3(transform.position.x, transform.position.y - 7, transform.position.z);
                Vector3 left = new Vector3(transform.position.x - 7, transform.position.y, transform.position.z);
                Vector3 right = new Vector3(transform.position.x + 7, transform.position.y, transform.position.z);
                Gizmos.color = Color.blue;
                Gizmos.DrawLine (transform.position, up);
                Gizmos.DrawLine(transform.position, down);
                Gizmos.DrawLine(transform.position, left);
                Gizmos.DrawLine(transform.position, right);
                break;
            case Piece.Bishop:
                Vector3 diagonalBottomRight = new Vector3(transform.position.x + 7, transform.position.y - 7, transform.position.z);
                Vector3 diagonalBottomLeft = new Vector3(transform.position.x - 7, transform.position.y + 7, transform.position.z);
                Vector3 diagonalTopLeft = new Vector3(transform.position.x - 7, transform.position.y - 7, transform.position.z);
                Vector3 diagonalTopRight = new Vector3(transform.position.x + 7, transform.position.y + 7, transform.position.z);
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, diagonalBottomRight);
                Gizmos.DrawLine(transform.position, diagonalBottomLeft);
                Gizmos.DrawLine(transform.position, diagonalTopRight);
                Gizmos.DrawLine(transform.position, diagonalTopLeft);

                break;
            case Piece.Knight:
                //Up and Down
                Vector3 knightUp = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
                Vector3 knightMoveRightUp = new Vector3(knightUp.x + 1f, knightUp.y, knightUp.z);
                Vector3 knightMoveLeftUp = new Vector3(knightUp.x - 1f, knightUp.y, knightUp.z);
                Vector3 knightDown = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                Vector3 knightMoveRightDown = new Vector3(knightDown.x + 1f, knightDown.y, knightDown.z);
                Vector3 knightMoveLeftDown = new Vector3(knightDown.x - 1f, knightDown.y, knightDown.z);
                //Left and Right
                Vector3 knightLeft = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
                Vector3 knightRight = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
                Vector3 knightMoveUpLeft = new Vector3(knightLeft.x, knightLeft.y + 1, knightLeft.z);
                Vector3 knightMoveUpRight = new Vector3(knightRight.x, knightRight.y + 1, knightRight.z);
                Vector3 knightMoveDownRight = new Vector3(knightRight.x, knightRight.y - 1, knightRight.z);
                Vector3 knightMoveDownLeft = new Vector3(knightLeft.x, knightLeft.y - 1, knightLeft.z);
                //Drawing
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(knightUp, knightMoveRightUp);
                Gizmos.DrawLine(knightUp, knightMoveLeftUp);
                Gizmos.DrawLine(transform.position, knightUp);
                Gizmos.DrawLine(knightDown, knightMoveLeftDown);
                Gizmos.DrawLine(knightDown, knightMoveRightDown);
                Gizmos.DrawLine(transform.position, knightDown);

                Gizmos.DrawLine(knightRight, knightMoveDownRight);
                Gizmos.DrawLine(knightRight, knightMoveUpRight);
                Gizmos.DrawLine(transform.position, knightRight);
                Gizmos.DrawLine(knightLeft, knightMoveUpLeft);
                Gizmos.DrawLine(knightLeft, knightMoveDownLeft);
                Gizmos.DrawLine(transform.position, knightLeft);

                break;
            case Piece.Queen:
                diagonalBottomRight = new Vector3(transform.position.x + 7, transform.position.y - 7, transform.position.z);
                diagonalBottomLeft = new Vector3(transform.position.x - 7, transform.position.y + 7, transform.position.z);
                diagonalTopLeft = new Vector3(transform.position.x - 7, transform.position.y - 7, transform.position.z);
                diagonalTopRight = new Vector3(transform.position.x + 7, transform.position.y + 7, transform.position.z); 
                up = new Vector3(transform.position.x, transform.position.y + 7, transform.position.z);
                down = new Vector3(transform.position.x, transform.position.y - 7, transform.position.z);
                left = new Vector3(transform.position.x - 7, transform.position.y, transform.position.z);
                right = new Vector3(transform.position.x + 7, transform.position.y, transform.position.z);
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, up);
                Gizmos.DrawLine(transform.position, down);
                Gizmos.DrawLine(transform.position, left);
                Gizmos.DrawLine(transform.position, right);
                Gizmos.DrawLine(transform.position, diagonalBottomRight);
                Gizmos.DrawLine(transform.position, diagonalBottomLeft);
                Gizmos.DrawLine(transform.position, diagonalTopRight);
                Gizmos.DrawLine(transform.position, diagonalTopLeft);
                break;
            case Piece.King:
                diagonalBottomRight = new Vector3(transform.position.x + 1.5f, transform.position.y - 1.5f, transform.position.z);
                diagonalBottomLeft = new Vector3(transform.position.x - 1.5f, transform.position.y + 1.5f, transform.position.z);
                diagonalTopLeft = new Vector3(transform.position.x - 1.5f, transform.position.y - 1.5f, transform.position.z);
                diagonalTopRight = new Vector3(transform.position.x + 1.5f, transform.position.y + 1.5f, transform.position.z);
                up = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                down = new Vector3(transform.position.x, transform.position.y - 1.5f, transform.position.z);
                left = new Vector3(transform.position.x - 1.5f, transform.position.y, transform.position.z);
                right = new Vector3(transform.position.x + 1.5f, transform.position.y, transform.position.z);
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, up);
                Gizmos.DrawLine(transform.position, down);
                Gizmos.DrawLine(transform.position, left);
                Gizmos.DrawLine(transform.position, right);
                Gizmos.DrawLine(transform.position, diagonalBottomRight);
                Gizmos.DrawLine(transform.position, diagonalBottomLeft);
                Gizmos.DrawLine(transform.position, diagonalTopRight);
                Gizmos.DrawLine(transform.position, diagonalTopLeft);
                break;
        }
    }


}
