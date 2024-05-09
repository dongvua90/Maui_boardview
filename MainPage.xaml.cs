using System.Diagnostics;

namespace BoardView
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetRandomHighlight(object sender, EventArgs e)
        {
            boardmain.SetRanDomHighLight();
        }

        private void ClearHighlight(object sender, EventArgs e)
        {
            boardmain.ClearHighlight();
        }
    }

}
