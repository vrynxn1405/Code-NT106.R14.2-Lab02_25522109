using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai3 : Form
    {
        private const string InputFile = "input3.txt";
        private const string OutputFile = "output3.txt";

        public Bai3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.File.Exists(InputFile))
                {
                    MessageBox.Show("Không tìm thấy file input3.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = System.IO.File.ReadAllLines(InputFile);
                rtbInput.Clear(); 
                rtbOutput.Clear(); 
                System.Collections.Generic.List<string> results = new System.Collections.Generic.List<string>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string expr = line.Replace(" ", "").Replace("–", "-");
                    rtbInput.AppendText(expr + Environment.NewLine);

                    try
                    {
                        double res = Evaluate(expr);
                        string resultLine = $"{expr}={res}";
                        rtbOutput.AppendText(resultLine + Environment.NewLine);
                        results.Add(resultLine);
                    }
                    catch (Exception ex)
                    {
                        rtbOutput.AppendText($"{expr} = Lỗi: {ex.Message}\n");
                    }
                }

                System.IO.File.WriteAllLines(OutputFile, results);
                MessageBox.Show("Đã tính toán và ghi file output3.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Evaluate(string expression)
        {
            System.Collections.Generic.Stack<double> values = new System.Collections.Generic.Stack<double>();
            System.Collections.Generic.Stack<char> ops = new System.Collections.Generic.Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ') continue;

                if (expression[i] >= '0' && expression[i] <= '9')
                {
                    string sbuf = "";
                    while (i < expression.Length && ((expression[i] >= '0' && expression[i] <= '9') || expression[i] == '.'))
                    {
                        sbuf += expression[i++];
                    }
                    values.Push(double.Parse(sbuf));
                    i--;
                }
                else if (expression[i] == '(')
                {
                    ops.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (ops.Peek() != '(')
                    {
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Pop();
                }
                else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/')
                {
                    if (expression[i] == '-' && (i == 0 || expression[i - 1] == '(' || IsOperator(expression[i - 1])))
                    {
                        string sbuf = "-";
                        i++;
                        while (i < expression.Length && ((expression[i] >= '0' && expression[i] <= '9') || expression[i] == '.'))
                        {
                            sbuf += expression[i++];
                        }
                        values.Push(double.Parse(sbuf));
                        i--;
                        continue;
                    }

                    while (ops.Count > 0 && HasPrecedence(expression[i], ops.Peek()))
                    {
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Push(expression[i]);
                }
            }

            while (ops.Count > 0)
            {
                values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')') return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-')) return false;
            return true;
        }

        private double ApplyOp(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0) throw new DivideByZeroException("Lỗi chia cho 0");
                    return (double)a / b;
            }
            return 0;
        }
    }
}