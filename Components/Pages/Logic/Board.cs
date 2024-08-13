namespace blazorChess.Components.Pages.Logic {

public class BoardClass
{
public static readonly int[] Squares = new int[64];

    public static void Board() {

        Squares[0] = Piece.White | Piece.Bishop;
        Squares[32] = Piece.White | Piece.King;
        Squares[61] = Piece.Black | Piece.Queen;
    }
}
}