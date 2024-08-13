using Microsoft.VisualBasic;

namespace blazorChess.Components.Pages.Logic
{

    public class BoardClass
    {
        public static readonly int[] Squares = new int[64];
        public const string startingFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        public static void Board()
        {
            LoadPositionFromFen(startingFEN);
        }

        public static void LoadPositionFromFen(string fen)
        {
            var PieceFromFen = new Dictionary<char, int>()
            {
                ['k'] = Piece.King, 
                ['p'] = Piece.Pawn, 
                ['n'] = Piece.Knight, 
                ['b'] = Piece.Bishop, 
                ['r'] = Piece.Rook, 
                ['q'] = Piece.Queen
            };
            
            string fenBoard = fen.Split(' ')[0];
            int file = 0, rank = 0;

            foreach (char symbol in fenBoard)
            {
                if(symbol == '/') {
                    file = 0;
                    rank++;
                } else {
                    if (char.IsDigit(symbol))
                    {
                        file += (int) char.GetNumericValue(symbol);
                    } else {
                        int pieceColor = char.IsUpper(symbol) ? Piece.White : Piece.Black;
                        int pieceType = PieceFromFen[char.ToLower(symbol)];
                        Squares[rank * 8 + file] = pieceType | pieceColor;
                        file++;
                    }
                }
            }
        }
    }
}