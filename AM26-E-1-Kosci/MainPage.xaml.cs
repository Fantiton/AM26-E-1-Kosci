namespace AM26_E_1_Kosci
{
    public partial class MainPage : ContentPage
    {
        int[] dices = [0, 0, 0, 0, 0];
        int gameScore = 0;
        int rollScore = 0;

        public MainPage()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            DicesStack.Children.Clear();

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

            RollScoreLabel.Text = rollScore.ToString();
            GameScoreLabel.Text = gameScore.ToString();
        }

        private void RollButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            gameScore = 0;
            rollScore = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = 0;
            }

            Display();
        }
    }
}
