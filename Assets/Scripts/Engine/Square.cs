using UnityEngine;

namespace ChessEngine.Engine
{
    public class Square : MonoBehaviour
    {
        public Piece Piece;

        public Square()
        {
        }

        #region Constructors

        public Square(Piece piece)
        {
            Piece = new Piece(piece);
        }

        #endregion Constructors
    }
}