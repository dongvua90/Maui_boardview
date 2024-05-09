using Microsoft.Maui.Controls.Shapes;

namespace BoardView
{
    public enum PieceType {Emty,Wking,Wqueen,Wbishop,Wknight,Wrook,Wpawn,Bking,Bqueen,Bbishop,Bknight,Brook,Bpawn }
    public class Piece:Border
    {
        Image wking = new Image { Source = ImageSource.FromFile("Pieces/wking.png") };
        Image wqueen = new Image { Source = ImageSource.FromFile("Pieces/wqueen.png") };
        Image wbishop = new Image { Source = ImageSource.FromFile("Pieces/wbishop.png") };
        Image wknight = new Image { Source = ImageSource.FromFile("Pieces/wknight.png") };
        Image wrook = new Image { Source = ImageSource.FromFile("Pieces/wrook.png") };
        Image wpawn = new Image { Source = ImageSource.FromFile("Pieces/wpawn.png") };
        Image bking = new Image { Source = ImageSource.FromFile("Pieces/bking.png") };
        Image bqueen = new Image { Source = ImageSource.FromFile("Pieces/bqueen.png") };
        Image bbishop = new Image { Source = ImageSource.FromFile("Pieces/bbishop.png") };
        Image bknight = new Image { Source = ImageSource.FromFile("Pieces/bknight.png") };
        Image brook = new Image { Source = ImageSource.FromFile("Pieces/brook.png") };
        Image bpawn = new Image { Source = ImageSource.FromFile("Pieces/bpawn.png") };
        Image emty = new Image { Source = ImageSource.FromFile("Pieces/emty.png") };


        public int file, rank;


        private char type='-';

        public char Type
        {
            get { return type; }
            set
            {
                if(type != value)
                {
                    type = value;
                    switch(type)
                    {
                        case '-': this.Content = emty; break;
                        case 'K': this.Content = wking; break;
                        case 'Q': this.Content = wqueen; break;
                        case 'B': this.Content = wbishop; break;
                        case 'N': this.Content = wknight; break;
                        case 'R': this.Content = wrook; break;
                        case 'P': this.Content = wpawn; break;
                        case 'k': this.Content = bking; break;
                        case 'q': this.Content = bqueen; break;
                        case 'b': this.Content = bbishop; break;
                        case 'n': this.Content = bknight; break;
                        case 'r': this.Content = brook; break;
                        case 'p': this.Content = bpawn; break;
                    }
                }
            }
        }


        public Piece(int file,int rank) 
        {
            this.file = file;
            this.rank = rank;
            this.BackgroundColor = Colors.Transparent;
            this.StrokeThickness = 0;
        }

        public void Moving()
        {
            this.TranslateTo(4*this.Width, 4*this.Width, 3000, Easing.BounceOut);
        }
        public void Home()
        {
            this.TranslateTo(0, 0, 3000, Easing.BounceOut);
        }

    }
}
