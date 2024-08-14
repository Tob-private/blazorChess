namespace blazorChess.Components.Pages.Logic
{
    public static class Move
    {
        public static void DisplayMoves(int pieceInBinary, int squareIndex)
        {
            List<int>[] possibleMoves = new List<int>[27];

            Console.WriteLine("piece in binary: " + pieceInBinary);
            Console.WriteLine("square index: " + squareIndex);

        }
    }
}