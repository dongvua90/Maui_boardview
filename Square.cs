using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardView
{
    public enum SquareHighlight {None,From,To};

    public class Square: Border
    {


        public int file, rank;

        Color whiteSqColor = Color.FromArgb("#EBECD0");
        Color blackSqColor = Color.FromArgb("#779556");
        Color highlightFromColor = Color.FromArgb("#E4D8E4");
        Color highlightToColor  = Color.FromArgb("#C4D8E4");

        private SquareHighlight highlight=SquareHighlight.None;

        public SquareHighlight Highlight
        {
            get { return highlight; }
            set
            {
                if (highlight != value)
                {
                    highlight = value;
                    if (highlight == SquareHighlight.From)
                    {
                        this.Stroke = highlightFromColor;
                        this.StrokeThickness = 2;
                    }else if(highlight == SquareHighlight.To)
                    {
                        this.BackgroundColor=highlightToColor;
                        this.StrokeThickness = 4;
                    }
                    else
                    {
                        this.StrokeThickness=0;
                        //if ((file + rank) % 2 == 0)
                        //    this.BackgroundColor = whiteSqColor;
                        //else
                        //    this.BackgroundColor = blackSqColor;
                    }
                }
            }
        }


        public Square(int file,int rank) 
        {
            this.file = file;
            this.rank = rank;
            if ((file + rank) % 2 == 0)
            {
                this.BackgroundColor = whiteSqColor;
            }
            else
            {
                this.BackgroundColor = blackSqColor;
            }
            this.StrokeThickness = 0;
            this.Padding = 0;
            Image img = new Image { Source = ImageSource.FromFile("dotnet_logo.png") };
            this.Content = img;
        }

    }
}
