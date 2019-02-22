using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula02.Class;

namespace Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Poker poker = new Poker();

            var chars = "AKJQ123456789";
            var random = new Random();
            var mao1 = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            var chars2 = "AKJQ123456789";
            var random2 = new Random();
            var mao2 = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            string sequencia = poker.Straight(mao1, mao2);

            if (sequencia.Length == 5)
                MessageBox.Show("Straight" + Environment.NewLine + sequencia);
            else
                MessageBox.Show("Não rolou Straight" + Environment.NewLine + mao1.ToString());

        }
    }
}
