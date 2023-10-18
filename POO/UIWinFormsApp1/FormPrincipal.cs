using POO;
namespace UIWinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        Carro meuCarro;
        public FormPrincipal()
        {
            InitializeComponent();
            meuCarro = new Carro("Chevrolet", "Sedan", "Branco", 2020, "bgt555y", 50, 100, 160);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Exibir();

            /*Console.WriteLine("\nPneuDianteiroEsquerdo: ");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuDianteiroDireito: ");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuTraseiroEsquerdo: ");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTraseiroDireito: ");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneuDeEstepe: ");
            PneuDeEstepe.Exibir();*/
        }

        private void Exibir()
        {
            textBoxExibir.Text = "Marca: " + meuCarro.Marca;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nModelo: " + meuCarro.Modelo;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCor: " + meuCarro.Cor;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nano: " + meuCarro.ano;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPlaca: " + meuCarro.Placa;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCapacidadeDoTanque: " + meuCarro.CapacidadeDoTanque;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPercentualDeCombustivel: " + meuCarro.PercentualDeCombustivel;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nLigado: " + meuCarro.Ligado;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidadeMaxima: " + meuCarro.VelocidadeMaxima;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidadeAtual: " + meuCarro.VelocidadeAtual;

            ExibirPneu(meuCarro.PneuDianteiroEsquerdo, textBoxPneuDianteiroEsquerdo);
            ExibirPneu(meuCarro.PneuDianteiroDireito, textBoxPneuDianteiroDireito);
            ExibirPneu(meuCarro.PneuTraseiroEsquerdo, textBoxPneuTraseiroEsquerdo);
            ExibirPneu(meuCarro.PneuTraseiroDireito, textBoxPneuTraseiroDireito);
            ExibirPneu(meuCarro.PneuDeEstepe, textBoxPneuDeEstepe);

            if (meuCarro.Ligado)
                buttonLigar.Text = "Desligar";
            else
                buttonLigar.Text = "Ligar";   
        }

        private void ExibirPneu(Pneu _pneu, TextBox _textBox)
        {
            _textBox.Text = "Aro: " + _pneu.Aro;
            _textBox.Text = _textBox.Text + "\r\nMarca: " + _pneu.Marca;
            _textBox.Text = _textBox.Text + "\r\nPSI: " + _pneu.PSI;
            _textBox.Text = _textBox.Text + "\r\nPSIMaximo: " + _pneu.PSIMaximo;
            _textBox.Text = _textBox.Text + "\r\nPSIMinino: " + _pneu.PSIMinino;
            _textBox.Text = _textBox.Text + "\r\nLargura: " + _pneu.Largura;
            _textBox.Text = _textBox.Text + "\r\nPercentualBorracha: " + _pneu.PercentualBorracha;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeMaxima: " + _pneu.VelocidadeMaxima;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeAtual: " + _pneu.VelocidadeAtual;
            _textBox.Text = _textBox.Text + "\r\nCargaAtual: " + _pneu.CargaAtual;
            _textBox.Text = _textBox.Text + "\r\nCargaMaxima: " + _pneu.CargaMaxima;
            _textBox.Text = _textBox.Text + "\r\nEstourado: " + _pneu.Estourado;
            _textBox.Text = _textBox.Text + "\r\nFurado: " + _pneu.Furado;
            _textBox.Text = _textBox.Text + "\r\nEstepe: " + _pneu.Estepe;


            _textBox.BackColor = Color.White;

            if (_pneu.Estourado)
            {
                _textBox.BackColor = Color.Red;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBoxPneuDianteiroDireito_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonLigar_Click(object sender, EventArgs e)
        {
            if (meuCarro.Ligado)
                meuCarro.Desligar();     
            else
                meuCarro.Ligar();
            
            Exibir();
        }
        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            meuCarro.Acelerar(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }
        private void buttonFrear_Click(object sender, EventArgs e)
        {
            meuCarro.Frear(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }

        private void buttonTrocarPneu_Click(object sender, EventArgs e)
        {
            try
            {
                Pneu pneu = null;

                switch (comboBoxPneu.SelectedIndex)
                {
                    case 0:
                        pneu = meuCarro.PneuDianteiroEsquerdo;
                        meuCarro.PneuDianteiroEsquerdo = meuCarro.PneuDeEstepe;
                        break;
                    case 1:
                        pneu = meuCarro.PneuDianteiroDireito;
                        meuCarro.PneuDianteiroDireito = meuCarro.PneuDeEstepe;
                        break;
                    case 2:
                        pneu = meuCarro.PneuTraseiroEsquerdo;
                        meuCarro.PneuTraseiroEsquerdo = meuCarro.PneuDeEstepe;
                        break;
                    case 3:
                        pneu = meuCarro.PneuTraseiroDireito;
                        meuCarro.PneuTraseiroDireito = meuCarro.PneuDeEstepe;
                        break;
                    default:
                        break;
                }
                if (pneu != null)
                    meuCarro.PneuDeEstepe = pneu;

                Exibir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}