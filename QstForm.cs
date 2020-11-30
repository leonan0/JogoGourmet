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
    public partial class QstForm : Form
    {

        private List<PratosCaracteristicas> ListaPratosCaracteristicas;
        private List<Caracteristica> ListaCaracteristicas;
        private DialogResult resposta;

        public QstForm()
        {
            InitializeComponent();

            Caracteristica salgado = new Caracteristica("Salgado");
            Caracteristica massa = new Caracteristica("Massa");
            Caracteristica doce = new Caracteristica("Doce");

            ListaCaracteristicas = new List<Caracteristica>
            {
                salgado,
                massa,
                doce
            };

            Prato lasanha = new Prato("Lasanha");
            Prato batata = new Prato("Batata");
            Prato bolo = new Prato("Bolo de Chocolate");
            Prato nhoque = new Prato("Nhoque");
            Prato sorvete = new Prato("Sorvete");

            ListaPratosCaracteristicas = new List<PratosCaracteristicas>
            {
                new PratosCaracteristicas(lasanha, salgado),
                new PratosCaracteristicas(lasanha, massa),
                new PratosCaracteristicas(batata, salgado),
                new PratosCaracteristicas(bolo, doce),
                new PratosCaracteristicas(nhoque, salgado),
                new PratosCaracteristicas(nhoque, massa),
                new PratosCaracteristicas(sorvete, doce)

            };

        }

        private void Bt_Iniciar_Click(object sender, EventArgs e)
        {
            ComecarJogo();
        }

        private void ComecarJogo()
        {
            Tentar();
        }

        private void Tentar()
        {
            int cont1, cont2;
            bool acerto = false;
            cont1 = 0;
            var pratoCaracteristica = ListaPratosCaracteristicas.FindAll(p => p.Caracteristica.GetDescricao() != "");

            while (!acerto)
            {
                try
                {
                    pratoCaracteristica = ListaPratosCaracteristicas.FindAll(h => h.Caracteristica.GetDescricao() == ListaCaracteristicas[cont1].GetDescricao());
                }
                catch (ArgumentOutOfRangeException)
                {
                    cont1 = 0;
                    pratoCaracteristica = ListaPratosCaracteristicas.FindAll(h => h.Caracteristica.GetDescricao() == ListaCaracteristicas[cont1].GetDescricao());
                }

                for (int x = 0; x < pratoCaracteristica.Count; x++)
                {
                    this.resposta = TentarCaracteristica(pratoCaracteristica[x]);

                    if (this.resposta == DialogResult.Yes)
                    {
                        cont2 = 0;
                        var pratos = ListaPratosCaracteristicas.FindAll(c => c.Caracteristica == pratoCaracteristica[x].Caracteristica);
                        while (cont2 < pratos.Count)
                        {

                            this.resposta = TentarPrato(pratos[cont2]);
                            cont2++;

                            if (this.resposta == DialogResult.Yes)
                            {
                                MessageBox.Show("Acertei!!!", "Acertei", MessageBoxButtons.OK);
                                acerto = true;
                                break;
                            }

                        }
                        if (cont2 >= pratos.Count && !acerto)
                        {
                            AddNovoPrato(ListaPratosCaracteristicas[cont1]);
                            acerto = true;
                        }
                    }
                    else
                    {
                        break;
                    }

                    if (acerto)
                        break;
                }
                cont1++;
                if (acerto)
                    break;
            }

        }

        private void AddNovoPrato(PratosCaracteristicas pratosCaracteristicas)
        {
            bool resposta = false;

            while (!resposta)
            {
                var nome = Interaction.InputBox($"Qual o prato que você pensou?", "Desisto", string.Empty);
                var descricao = Interaction.InputBox($"{nome} é _______ mas {pratosCaracteristicas.Prato.GetNome()} não", "Complete", string.Empty);

                if (nome.Trim() == string.Empty || descricao.Trim() == string.Empty)
                {
                    MessageBox.Show("Você não me contou o prato que estava pensando", "", MessageBoxButtons.OK);
                }
                else if (descricao.Trim() == string.Empty)
                {
                    MessageBox.Show($"Você não me contou a diferença entre {pratosCaracteristicas.Prato.GetNome()} e {nome} ", "", MessageBoxButtons.OK);
                }
                else
                {
                    var prato = ListaPratosCaracteristicas.Find(x => x.Prato.GetNome() == nome);
                    var caracteristica = ListaPratosCaracteristicas.Find(x => x.Caracteristica.GetDescricao() == descricao);
                    if (prato != null && caracteristica != null)
                    {
                        ListaPratosCaracteristicas.Add(new PratosCaracteristicas(prato.Prato, caracteristica.Caracteristica));
                    }
                    else if(prato == null && caracteristica != null)
                    {
                        var _prato = new Prato(nome);
                        ListaPratosCaracteristicas.Add(new PratosCaracteristicas(_prato, caracteristica.Caracteristica));
                        ListaPratosCaracteristicas.Add(new PratosCaracteristicas(_prato, pratosCaracteristicas.Caracteristica));

                    }
                    else if(caracteristica == null && prato != null)
                    {
                        var _carac = new Caracteristica(descricao);
                        ListaCaracteristicas.Add(_carac);
                        ListaPratosCaracteristicas.Add(new PratosCaracteristicas(prato.Prato, _carac));
                        ListaPratosCaracteristicas.Add(new PratosCaracteristicas(prato.Prato, pratosCaracteristicas.Caracteristica));
                    }
                    else
                    {
                        var _prato = new Prato(nome);
                        var _carac = new Caracteristica(descricao);
                        ListaCaracteristicas.Add(_carac);
                        ListaPratosCaracteristicas.Add(new PratosCaracteristicas(_prato, _carac));
                        ListaPratosCaracteristicas.Add(new PratosCaracteristicas(_prato, pratosCaracteristicas.Caracteristica));
                    }
                    resposta = true;
                }


            }
        }

        private DialogResult TentarCaracteristica(PratosCaracteristicas pratosCaracteristicas)
        {

            return MessageBox.Show($"O prato que você pensou é {pratosCaracteristicas.Caracteristica.GetDescricao()} ?", "", MessageBoxButtons.YesNo);
        }

        private DialogResult TentarPrato(PratosCaracteristicas pratosCaracteristicas)
        {
            return MessageBox.Show($"O Prato que você pensou seria {pratosCaracteristicas.Prato.GetNome()}?", "", MessageBoxButtons.YesNo);
        }


    }
}
