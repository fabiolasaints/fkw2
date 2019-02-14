using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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



            //Straight
            List<string> cartasMao1 = new List<string>();
            cartasMao1.Add(mao1.Substring(0, 1));
            cartasMao1.Add(mao1.Substring(1, 1));
            cartasMao1.Add(mao1.Substring(2, 1));
            cartasMao1.Add(mao1.Substring(3, 1));
            cartasMao1.Add(mao1.Substring(4, 1));

            cartasMao1.OrderBy(c => c).ToList();
            List<string> mao1Aux = new List<string>();

            foreach (var item in cartasMao1)
            {

                switch (item)
                {
                    case "J":
                        mao1Aux.Add("11");
                        break;
                    case "Q":
                        mao1Aux.Add("12");
                        break;
                    case "K":
                        mao1Aux.Add("13");
                        break;
                    case "A":
                        mao1Aux.Add("14");
                        break;
                    default:
                        mao1Aux.Add(item);
                        break;
                }

            }

            cartasMao1 = mao1Aux;
            cartasMao1.OrderBy(c => c).ToList();

            foreach (var item in cartasMao1)
            {
                int seq = 0;
                int controle = 0;
                string sequencia = string.Empty;

                if (sequencia.Length == 0)
                {
                    controle = seq;
                    sequencia = sequencia + item.ToString();
                }
                else
                {
                    if (controle + 1 == seq)
                        sequencia = sequencia + item.ToString();
                }

                if (sequencia.Length == 5)
                    MessageBox.Show("Straight" + Environment.NewLine + sequencia);
                else
                    MessageBox.Show("Não rolou Straight" + Environment.NewLine + mao1.ToString());

            }

        }
    }
}
