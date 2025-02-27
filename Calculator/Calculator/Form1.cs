using System.ComponentModel.Design;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double saveNum = 0;
        List<char> saveNum2 = ['0'];
        string equationType = "";
        Boolean hasComma;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (saveNum2.Count < 8 && saveNum2[0] != '0')
            {
                txtMonitor.Text += "0";
                saveNum2.Add('0');
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            addNumber('1');
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text != "")
            {
                saveNum = Convert.ToDouble(txtMonitor.Text);
                equationType = "plus";
                txtMonitor.Text = "0";
                saveNum2.Clear();
                saveNum2.Add('0');
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (equationType == "plus")
            {
                txtMonitor.Text = Convert.ToString(saveNum + Convert.ToDouble(txtMonitor.Text));
            }
            else if (equationType == "minus")
            {
                txtMonitor.Text = Convert.ToString(saveNum - Convert.ToDouble(txtMonitor.Text));
            }
            else if (equationType == "multiplication")
            {
                txtMonitor.Text = Convert.ToString(saveNum * Convert.ToDouble(txtMonitor.Text));
            }
            else if (equationType == "division")
            {
                txtMonitor.Text = Convert.ToString(saveNum / Convert.ToDouble(txtMonitor.Text));
            }
            else if (equationType == "module")
            {
                txtMonitor.Text = Convert.ToString(saveNum % Convert.ToDouble(txtMonitor.Text));
            }

            equationType = "";
            saveNum2 = txtMonitor.Text.ToList();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            addNumber('2');
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            addNumber('3');
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            addNumber('4');
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            addNumber('5');
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            addNumber('6');
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            addNumber('7');
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            addNumber('8');
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            addNumber('9');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text != "")
            {
                saveNum = Convert.ToDouble(txtMonitor.Text);
                equationType = "minus";
                txtMonitor.Text = "0";
                saveNum2.Clear();
                saveNum2.Add('0');
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hasComma == false)
            {
                addNumber(',');
                hasComma = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text != "")
            {
                saveNum = Convert.ToDouble(txtMonitor.Text);
                equationType = "multiplication";
                txtMonitor.Text = "0";
                saveNum2.Clear();
                saveNum2.Add('0');
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text != "")
            {
                saveNum = Convert.ToDouble(txtMonitor.Text);
                equationType = "division";
                txtMonitor.Text = "0";
                saveNum2.Clear();
                saveNum2.Add('0');
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtMonitor.Text = "0";
            saveNum = 0;
            equationType = "";
            saveNum2.Clear();
            saveNum2.Add('0');
        }

        void addNumber(char number)
        {
            if (saveNum2.Count < 8)
            {
                if(saveNum2[0] == '0' && hasComma == false)
                {
                    txtMonitor.Text = "";
                    saveNum2.Clear();
                }
                txtMonitor.Text += Convert.ToString(number);
                saveNum2.Add(number);
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (saveNum2.Count > 0 && saveNum2[0] != '0')
            {
                if(saveNum2.Count == 1)
                {
                    txtMonitor.Text = "0";
                    saveNum2.Clear();
                    saveNum2.Add('0');
                }
                else
                {
                    saveNum2.RemoveAt(saveNum2.Count - 1);
                    txtMonitor.Text = "";
                    saveNum2.ForEach(item => { txtMonitor.Text += item; });
                    if (txtMonitor.Text != "")
                    {
                        saveNum = Convert.ToDouble(txtMonitor.Text);
                    }
                    else
                    {
                        saveNum = 0;
                    }
                }
                
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text != "")
            {
                saveNum = Convert.ToDouble(txtMonitor.Text);
                txtMonitor.Text = Convert.ToString(Math.Sqrt(saveNum));
                saveNum2.Clear();
                saveNum2 = txtMonitor.Text.ToList();
            }

        }

        private void btnElevated_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text != "")
            {
                saveNum = Convert.ToDouble(txtMonitor.Text);
                saveNum = saveNum * saveNum;
                txtMonitor.Text = Convert.ToString(saveNum);
                saveNum2.Clear();
                saveNum2 = txtMonitor.Text.ToList();
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text != "")
            {
                saveNum = Convert.ToDouble(txtMonitor.Text);
                equationType = "module";
                txtMonitor.Text = "0";
                saveNum2.Clear();
                saveNum2.Add('0');
            }
        }
    }
}
