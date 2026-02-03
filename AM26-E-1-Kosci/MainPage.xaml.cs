namespace AM26_E_1_Kosci
{
    public partial class MainPage : ContentPage
    {
        int[] dices = [0, 0, 0, 0, 0];

        public MainPage()
        {
            InitializeComponent();
            DisplayDices();
        }

        private void DisplayDices()
        {
            foreach (int dice in dices) 
            {
                string imgPath = "";
                switch (dice)
                {
                    case 0:
                        imgPath = "question.jpg";
                        break;
                }

                Image diceImg = new Image();
                diceImg.Margin = 10;
                diceImg.Source = imgPath;
                DicesStack.Children.Add(diceImg);
            }
        }

        private void RollButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
