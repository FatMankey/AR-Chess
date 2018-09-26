namespace ChessEngine.Engine
{
    public struct Square
    {
        public Piece Piece;

        #region Constructors

         public Square(Piece piece)
        {
            Piece = new Piece(piece);
        }

        #endregion
    }
}