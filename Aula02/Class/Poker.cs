using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Class
{
    public class Poker
    {

        public string Straight(string mao1, string mao2 )
        {
            //Straight
            List<string> cartasMao1 = new List<string>();
            cartasMao1.Add(mao1.Substring(0, 1));
            cartasMao1.Add(mao1.Substring(1, 1));
            cartasMao1.Add(mao1.Substring(2, 1));
            cartasMao1.Add(mao1.Substring(3, 1));
            cartasMao1.Add(mao1.Substring(4, 1));

            cartasMao1 = cartasMao1.OrderBy(c => c).ToList();
            List<int> mao1Aux = new List<int>();

            foreach (var item in cartasMao1)
            {
                switch (item)
                {
                    case "J":
                        mao1Aux.Add(11);
                        break;
                    case "Q":
                        mao1Aux.Add(12);
                        break;
                    case "K":
                        mao1Aux.Add(13);
                        break;
                    case "A":
                        mao1Aux.Add(14);
                        break;
                    default:
                        mao1Aux.Add(Convert.ToInt32(item));
                        break;
                }

            }


            mao1Aux = mao1Aux.OrderBy(c => c).ToList();
            string sequencia = string.Empty;
            string saida = string.Empty;
            int controle = 0;

            foreach (var item in mao1Aux)
            {
                int seq = item;

                switch (item)
                {
                    case 11:
                        sequencia = "J";
                        break;
                    case 12:
                        sequencia = "J";
                        break;
                    case 13:
                        sequencia = "K";
                        break;
                    case 14:
                        sequencia = "A";
                        break;
                    default:
                        sequencia = item.ToString();
                        break;
                }

                if (controle == 0)
                {
                    controle = seq;
                    saida = item.ToString();
                }
                else
                {
                    if (controle + 1 == seq)
                        saida = saida + item.ToString();

                    controle = seq;
                }

            }



            controle = 0;


            return saida;
        }

    }
}
