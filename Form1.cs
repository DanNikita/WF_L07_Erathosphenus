namespace L07_Erathosphenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string res1 = await Gobut1();
            txtbxResult.Text = res1;
        }
        public string GoButt()
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new
            System.Text.StringBuilder();
            if (int.TryParse(MaxValue.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            return resultText.ToString();
        }
        private async Task<string> Gobut1()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                int maxValue = 0;
                System.Text.StringBuilder resultText = new
                System.Text.StringBuilder();
                if (int.TryParse(MaxValue.Text, out maxValue))
                {
                    for (int trial = 2; trial <= maxValue; trial++)
                    {
                        bool isPrime = true;
                        for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                        {
                            if (trial % divisor == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            resultText.AppendFormat("{0} ", trial);
                        }
                    }
                }
                else
                {
                    resultText.Append("Unable to parse maximum value.");
                }
                return resultText.ToString();
            }
            );
        }

    }

}
