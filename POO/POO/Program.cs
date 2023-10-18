namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu meuPneu = new Pneu(17, "Michelin", 33, 38, 25, 240, 500);
            Pneu troca;

            Carro meuCarro = new Carro("Chevrolet", "Sedan", "Branco", 2020,"bgt555y", 50,100, 160);
            meuCarro.Ligar();
            meuCarro.Acelerar(5);
            meuCarro.Acelerar(15);
            meuCarro.Acelerar(6);
            meuCarro.Desligar();
            meuCarro.PneuDianteiroEsquerdo = meuPneu;
            meuCarro.Ligar();
            meuCarro.Acelerar(7);
            meuCarro.Acelerar(7);
            meuCarro.Frear(3);
            meuCarro.Acelerar(6);
            meuCarro.Frear(4);
            meuCarro.Desligar();
            troca = meuCarro.PneuDianteiroDireito;
            meuCarro.PneuDianteiroDireito = meuCarro.PneuDeEstepe;
            meuCarro.PneuDeEstepe = troca;
            meuCarro.Ligar();
            meuCarro.Acelerar(7);
            meuCarro.Acelerar(7);
            meuCarro.Frear(3);
            meuCarro.Acelerar(6);
            meuCarro.Frear(4);
            meuCarro.Desligar();

            troca = meuCarro.PneuDianteiroDireito;
            meuCarro.PneuTraseiroDireito = meuCarro.PneuDeEstepe;
            meuCarro.PneuDeEstepe = troca;
            meuCarro.Ligar();
            meuCarro.Acelerar(7);
            meuCarro.Acelerar(7);
            meuCarro.Frear(3);
            meuCarro.Acelerar(6);
            meuCarro.Frear(4);
            meuCarro.Frear(4);
            meuCarro.Acelerar(10);
            meuCarro.Exibir();

            /*meuPneu.Exibir();
            meuPneu.Acelerar(10);
            meuPneu.Exibir();
            meuPneu.Acelerar(5);
            meuPneu.Exibir();
            meuPneu.Acelerar(7);
            meuPneu.Exibir();
            meuPneu.Acelerar(3);
            meuPneu.Exibir();
            meuPneu.Acelerar(2);
            meuPneu.Exibir();
            meuPneu.Frear(15);
            meuPneu.Exibir();
            */
        }
    }
}