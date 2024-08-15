namespace blazorChess.Components.Pages.Logic
{
    public class Move
    {
        public static readonly List<int> possibleMoves = [];
        public static void DisplayMoves(int pieceInBinary, int squareIndex)
        {
            Console.WriteLine("----------------------------------------------------------");
            string pieceString = pieceInBinary.ToString();
            bool isWhite = pieceString.Length == 4;
            int pieceType = isWhite ? int.Parse(pieceString[1..]) : int.Parse(pieceString[2..]);

            string pieceColor = isWhite ? "White" : "Black";
            string pieceName = GetPieceName(pieceType);


            if (pieceName != "Unknown Piece name")
            {
                Console.WriteLine($"{pieceColor} {pieceName} press");
                List<int> moves = []/* Fill by calling a calc-PIECENAME-moves func */;
                foreach (var move in moves)
                {
                    possibleMoves.Add(move);
                }
            }
            else
            {
                Console.WriteLine("Unknown Piece name in move class");
            }

            Console.WriteLine("square index: " + squareIndex);
        }

        private static string GetPieceName(int pieceType)
        {
            return pieceType switch
            {
                int type when type == int.Parse(Convert.ToString(Piece.Pawn, 2)) => "Pawn",
                int type when type == int.Parse(Convert.ToString(Piece.Queen, 2)) => "Queen",
                int type when type == int.Parse(Convert.ToString(Piece.King, 2)) => "King",
                int type when type == int.Parse(Convert.ToString(Piece.Knight, 2)) => "Knight",
                int type when type == int.Parse(Convert.ToString(Piece.Rook, 2)) => "Rook",
                int type when type == int.Parse(Convert.ToString(Piece.Bishop, 2)) => "Bishop",
                _ => "Unknown Piece name"
            };
        }


        public static void MovePiece(List<int> squaresArray, int currentIndex, int newIndex)
        {
            int selectedPiece = squaresArray[currentIndex];
            squaresArray.RemoveAt(currentIndex);
            squaresArray.Insert(newIndex, selectedPiece);
        }
    }
}