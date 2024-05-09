using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardView
{
    public class Board:AbsoluteLayout
    {
        Square[,] squares = new Square[8, 8];
        List<Piece> pieces = new List<Piece>(); 
        private string fen = "rnbqkbnrpppppppp--------------------------------PPPPPPPPRNBQKBNR";

        double sqsize;

        public string Fen
        {
            get { return fen; }
            set
            {
                if(fen != value)
                {
                    fen = value;
                    if (fen.Length >= 64)
                    {
                        for(int i = 0; i < 64; i++)
                        {
                            char c = fen[i];
                            switch (c)
                            {
                                case 'K':break;
                            }
                        }
                    }
                }
            }
        }


        public Board()
        {
            // add Squares
            for(int rank = 0; rank < 8; rank++)
            {
                for(int file=0;file < 8; file++)
                {
                    Square square = new Square(file,rank);
                    squares[file,rank] = square;
                    this.Add(square);
                }
            }
            // add Pieces
            initPieces();

            SizeChanged += (object? sender, EventArgs e) =>
            {
                Board? b = sender as Board;
                if (b == null) return;
                sqsize = Math.Min(b.Width, b.Height) / 8;
                foreach(Square square in squares)
                {
                    AbsoluteLayout.SetLayoutBounds(square,new Rect(square.file*sqsize,square.rank*sqsize,sqsize,sqsize));
                }
                // change position pieces
                foreach(Piece piece in pieces)
                {
                    AbsoluteLayout.SetLayoutBounds(piece, new Rect(piece.file * sqsize, piece.rank * sqsize, sqsize, sqsize));
                }
            };
            
        }
        void initPieces()
        {
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    int index = rank * 8 + file;
                    if (fen.Length >= 64)
                    {
                        char c = fen[index];
                        if (c != '-')
                        {
                            Piece piece = new Piece(file, rank);
                            piece.Type = c;
                            pieces.Add(piece);
                            this.Add(piece);
                        }
                    }
                    
                }
            }
        }

        public void SetRanDomHighLight()
        {
            pieces[2].Moving();
             //pieces[0].Type = 'k';
            //Random random = new Random();
            //int file = random.Next(0, 7);
            //int rank = random.Next(0, 7);
            //int highlight = random.Next(1, 2);
            //squares[file, rank].Highlight = (SquareHighlight)highlight;
        }
        public void ClearHighlight()
        {
            pieces[2].Home();
            //pieces[0].Type = 'K';
            //foreach (Square square in squares)
            //{
            //    square.Highlight = SquareHighlight.None;
            //}
        }
    }
}
