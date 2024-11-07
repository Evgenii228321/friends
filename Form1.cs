namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Label resultLabel;
        private TextBox num1TextBox;
        private TextBox num2TextBox;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        public Form1()
        {
            InitializeComponent();
            // Настройка элементов управления
            resultLabel = new Label();
            resultLabel.Location = new Point(10, 10);
            resultLabel.AutoSize = true;
            resultLabel.Text = "Результат:";
            Controls.Add(resultLabel);

            num1TextBox = new TextBox();
            num1TextBox.Location = new Point(10, 40);
            num1TextBox.Size = new Size(100, 20);
            Controls.Add(num1TextBox);

            num2TextBox = new TextBox();
            num2TextBox.Location = new Point(120, 40);
            num2TextBox.Size = new Size(100, 20);
            Controls.Add(num2TextBox);

            addButton = new Button();
            addButton.Location = new Point(10, 80);
            addButton.Text = "+";
            addButton.Click += AddButton_Click;
            Controls.Add(addButton);

            subtractButton = new Button();
            subtractButton.Location = new Point(80, 80);
            subtractButton.Text = "-";
            subtractButton.Click += SubtractButton_Click;
            Controls.Add(subtractButton);

            multiplyButton = new Button();
            multiplyButton.Location = new Point(150, 80);
            multiplyButton.Text = "*";
            multiplyButton.Click += MultiplyButton_Click;
            Controls.Add(multiplyButton);

            divideButton = new Button();
            divideButton.Location = new Point(220, 80);
            divideButton.Text = "/";
            divideButton.Click += DivideButton_Click;
            Controls.Add(divideButton);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CalculateResult("+");
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            CalculateResult("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            CalculateResult("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            CalculateResult("/");
        }

        private void CalculateResult(string operation)
        {
            try
            {
                double num1 = Convert.ToDouble(num1TextBox.Text);
                double num2 = Convert.ToDouble(num2TextBox.Text);

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Деление на ноль невозможно!");
                            return;
                        }
                        result = num1 / num2;
                        break;
                }

                resultLabel.Text = $"Результат: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ввода!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}