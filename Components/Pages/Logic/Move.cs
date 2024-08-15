namespace blazorChess.Components.Pages.Logic
{
    public static class Move
    {
        public static void DisplayMoves(int pieceInBinary, int squareIndex)
        {
            Console.WriteLine("----------------------------------------------------------");
            int pieceType;
            string pieceString = pieceInBinary.ToString();
            List<int>[] possibleMoves = new List<int>[27];
            if (pieceString.Length == 4) // White piece
            {
                pieceType = int.Parse(pieceString[1..]);

                if (pieceType == int.Parse(Convert.ToString(Piece.Pawn, 2)))
                {
                    Console.WriteLine("White Pawn press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Queen, 2)))
                {
                    Console.WriteLine("White Queen press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.King, 2)))
                {
                    Console.WriteLine("White King press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Knight, 2)))
                {
                    Console.WriteLine("White Knight press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Rook, 2)))
                {
                    Console.WriteLine("White Rook press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Bishop, 2)))
                {
                    Console.WriteLine("White Bishop press");
                }


            }
            if (pieceString.Length == 5) // Black piece
            {
                pieceType = int.Parse(pieceString[2..]);

                if (pieceType == int.Parse(Convert.ToString(Piece.Pawn, 2)))
                {
                    Console.WriteLine("Black Pawn press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Queen, 2)))
                {
                    Console.WriteLine("Black Queen press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.King, 2)))
                {
                    Console.WriteLine("Black King press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Knight, 2)))
                {
                    Console.WriteLine("Black Knight press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Rook, 2)))
                {
                    Console.WriteLine("Black Rook press");
                }
                else if (pieceType == int.Parse(Convert.ToString(Piece.Bishop, 2)))
                {
                    Console.WriteLine("Black Bishop press");
                }
            }

            Console.WriteLine("square index: " + squareIndex);

        }

        public static void MovePiece(List<int> squaresArray, int currentIndex, int newIndex)
        {
            int selectedPiece = squaresArray[currentIndex];
            squaresArray.RemoveAt(currentIndex);
            squaresArray.Insert(newIndex, selectedPiece);
        }
    }
}