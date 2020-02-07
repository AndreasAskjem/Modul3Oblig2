namespace SimpleChess
{
    abstract class Piece
    {
        public string Symbol { get; protected set; }

        protected Piece()
        {

        }

        public abstract bool Move(string fromPosition, string toPosition);
    }
}