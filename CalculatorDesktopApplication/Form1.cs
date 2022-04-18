namespace CalculatorDesktopApplication
{
    public partial class Form1 : Form
    {
        private List<double > valueList=new List<double>();//���û����������
        private List<int> operatorList=new List<int>();
        //���û�����������������+Ϊ0��-Ϊ1��*Ϊ2��/Ϊ3

        //״̬��¼
        private bool add = false;//+����
        private bool minus = false;//-����
        private bool multi = false;//������
        private bool div = false;//�°���
        private bool result = false;//=����
        private bool can_operate = false;//����=�Ƿ���Ӧ


        public Form1()
        {
            InitializeComponent();
        }

        private void numDown(string num)
        {
            if(add || minus || multi || div || result)
            {
                if (result)//���µȺţ��ո�����һ�������״̬
                {
                    label1.Text = "";
                }
                textBox1.Clear();//����û��ո�������һ�������
                add = false;
                minus = false;
                multi = false;
                div = false;
                result = false;
            }
            if ((num.Equals(".") && textBox1.Text.IndexOf(".") < 0) || !num.Equals("."))
            {
                //����û��������С����.����Ҫ�жϵ�ǰ��������������Ƿ���С����.����������
                textBox1.Text += num;
                label1.Text += num;
                can_operate = true;
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            numDown("0");
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            numDown("1");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            numDown("2");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numDown("3");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            numDown("4");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            numDown("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            numDown("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            numDown("7");
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            numDown("8");
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            numDown("9");
        }

        private void bt_point_Click(object sender, EventArgs e)
        {
            numDown(".");
        }


        //���ż�������
        private void bt_plus_Click(object sender, EventArgs e)
        {
            if (!add)//��ֹ�û��������һ�����ż������ż�ֻ��������һ��
            {
                result = false;
                valueList.Add(double.Parse(textBox1.Text));//����ǰ����������ַ���valueList
                operatorList.Add(0);
                label1.Text += "+";
                add = true;
                can_operate = false;//�ո���������ţ����ܹ���һ�������ı��ʽ����111+������Ϊ��������״̬
            }
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            if (!minus)
            {
                result = false;
                valueList.Add(double.Parse(textBox1.Text));
                operatorList.Add(1);
                label1.Text += "-";
                minus = true;
                can_operate = false;
             }
        }

        private void bt_multi_Click(object sender, EventArgs e)
        {
            if (!multi)
            {
                result = false;
                valueList.Add(double.Parse(textBox1.Text));
                operatorList.Add(2);
                label1.Text = "(" + label1.Text + ")" + "��";//��ǰ����Ѿ�����Ķ����Ӹ����š��������ջ������һ���ܸ��ӵ����ݽṹ���⣬���ﲻ������P��
                multi = true;
                can_operate = false;
            }
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            if (!div)
            {
                result = false;
                valueList.Add(double.Parse(textBox1.Text));
                operatorList.Add(3);
                label1.Text = "(" + label1.Text + ")" + "��";
                div = true;
                can_operate = false;
            }
        }

        private void bt_result_Click(object sender, EventArgs e)
        {
            if (valueList.Count > 0 && operatorList.Count > 0 && can_operate)
            {//��Ҫ��ֹ�û�û�������֣�����ֻ������һ�������Ͱ�=��
                valueList.Add(double.Parse(textBox1.Text));
                double total = valueList[0];
                for (int i = 0; i < operatorList.Count; i++)
                {
                    int _operator = operatorList[i];//operator��C#����������صĹؼ��֣�ǰ��Ӹ�_������
                    switch (_operator)
                    {
                        case 0:
                            total += valueList[i + 1];
                            break;
                        case 1:
                            total -= valueList[i + 1];
                            break;
                        case 2:
                            total *= valueList[i + 1];
                            break;
                        case 3:
                            total /= valueList[i + 1];
                            break;
                    }
                }
                textBox1.Text = total + "";
                label1.Text = total + "";
                operatorList.Clear();//���꣬������ۻ���������������
                valueList.Clear();
                result = true;//��ʾ=����
            }
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            operatorList.Clear();
            valueList.Clear();
            add = false;
            minus = false;
            multi = false;
            div = false;
            result = false;
            can_operate = false;
            textBox1.Clear();
            label1.Text = "";
        }

        private void binay_Click(object sender, EventArgs e)
        {
            double dec = double.Parse(textBox1.Text);
            textBox1.Text = CovertToBinary(dec);
        }

        public string CovertToBinary(double Dec)
        {
            int maxPow = 0;
            string binary = "";
            while (Math.Pow(2, maxPow) < Dec)
            {
                maxPow++;
            }
            maxPow--;
            for (int i = maxPow; i >= 0; i--)
            {
                if (Math.Pow(2, i) <= Dec)
                {
                    binary += "1";
                    Dec = Dec - Math.Pow(2, i);
                }
                else
                {
                    binary += "0";
                }
            }
            return binary;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            string dec = textBox1.Text.ToString();
            textBox1.Text = ConvertToDecimal(dec).ToString();
        }

        private double ConvertToDecimal(string Bin)
        {
            double Dec = 0;
            var length = Bin.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                if (Bin[length - 1 - i] == '1')
                {
                    Dec += Math.Pow(2, i);
                }
            }
            return Dec;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double dec = double.Parse(textBox1.Text);
            textBox1.Text = CovertToLocation(dec);
            Change(textBox1.Text);
            textBox1.Text = Change(textBox1.Text);
        }

        private string Change(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string CovertToLocation(double Dec)
        {
            char[] letterArr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int maxPow = 0;
            string loc = "";
            while (Math.Pow(2, maxPow) < Dec)
            {
                maxPow++;
            }
            maxPow--;
            for (int i = maxPow; i >= 0; i--)
            {
                if (Math.Pow(2, i) <= Dec)
                {
                    loc += letterArr[i];
                    Dec = Dec - Math.Pow(2, i);
                }
            }
            return loc;
        }
    }
}