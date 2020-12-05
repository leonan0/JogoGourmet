using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class Form_Prin : Form
    {
        private readonly List<Prato> ListaPratos;
        private DialogResult resposta;
        public Form_Prin()
        {
            InitializeComponent();
            ListaPratos = new List<Prato>
            {
                new Prato("Lasanha","Massa"),
                new Prato("Bolo de Chocolate","")
            };

        }

        private void Bt_Iniciar_Click(object sender, EventArgs e)
        {
            Tentar();
        }

        private DialogResult TentaPrato(Prato prato, bool final)
        {
            if (final)
                return MessageBox.Show($"O prato que você pensou é {prato.GetNome()}?", "Confirm", MessageBoxButtons.YesNo);
            else
                return MessageBox.Show($"O prato que você pensou é {prato.GetCaracteristica()}?", "Confirm", MessageBoxButtons.YesNo);
        }

        private void Tentar()
        {
            int pos = 0;
            int max = ListaPratos.Count();

            for (int i = 0; i < max; i++)
            {
                if (i == max - 1)
                    this.resposta = TentaPrato(ListaPratos[i], true);
                else
                {
                    try
                    {
                        this.resposta = TentaPrato(ListaPratos[i], false);
                        if (this.resposta == DialogResult.Yes)
                        {
                            this.resposta = TentaPrato(ListaPratos[i], true);

                            break;
                        }

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        this.resposta = TentaPrato(ListaPratos[i - 1], false);
                    }

                    pos = i;
                }
            }

            if (this.resposta == DialogResult.Yes)
            {
                MessageBox.Show("Acertei de novo!", "Acertei!", MessageBoxButtons.OK);
            }
            else
            {
                AddNovoPrato(pos);
            }
        }

        private void AddNovoPrato(int pos)
        {
            var nome = Interaction.InputBox($"Qual prato você pensou?", "Desisto", string.Empty);
            var caracteristica = Interaction.InputBox($"{nome} é _______ mas {ListaPratos[pos].GetNome()} não.", "Complete", string.Empty);
            nome = TrataString(nome);
            caracteristica = TrataString(caracteristica);



            ListaPratos.Insert(pos, new Prato(nome, caracteristica));
        }

        private string TrataString(string info)
        {
            info = info.Trim();
            if (info == "")
                info = "null";
            return info;

        }
    }
}
