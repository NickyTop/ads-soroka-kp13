using Hanoi.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi
{
    public partial class MainForm : Form
    {
        private Stack A { get; set; }
        private Stack B { get; set; }
        private Stack C { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private async Task Move(int discs, Stack from, Stack to, Stack interchange)
        {
            if (discs > 0)
            {
                await Move(discs - 1, from, interchange, to);
                await MoveDisc(from, to);
                await Move(discs - 1, interchange, to, from);
            }
        }

        private async Task MoveDisc(Stack from, Stack to)
        {
            var temp = from.Pop();
            to.Push(temp);

            await RefreshTextbox();
        }

        private async Task RefreshTextbox()
        {
            this.resultTb.Text = $"A = {this.A.ToString()}\nB = {this.B.ToString()}\nC = {this.C.ToString()}";

            await Task.Delay(500);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.A = new Stack();
                this.B = new Stack();
                this.C = new Stack();

                var data = this.inputTb.Text.Split(" ").Select(x => Convert.ToInt32(x)).ToList();

                // validation
                for (int i = 1; i < data.Count; i++)
                {
                    if (data[i - 1] < data[i])
                    {
                        throw new ArgumentException("Elements should be in the decreasing order!");
                    }
                }
                foreach (var value in data)
                {
                    this.A.Push(value);
                }

                await Move(data.Count, A, C, B);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex.Message}.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inputTb.Text = "9 6 4 2 1";
        }
    }
}
