namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        // Variável para rastrear de quem é a vez, "x" ou "O"
        string vez = "x";

        // Construtor da classe MainPage
        public MainPage()
        {
            InitializeComponent(); // Inicializa os componentes da interface
        }

        // Método chamado quando um botão é clicado
        private void Button_Clicked(object sender, EventArgs e)
        {
            // Captura o botão que foi clicado
            Button btn = (Button)sender;
            btn.IsEnabled = false; // Desabilita o botão para evitar múltiplos cliques

            // Alterna entre "x" e "O"
            if (vez == "x")
            {
                btn.Text = "x"; // Define o texto do botão como "x"
                vez = "O"; // Muda a vez para "O"
            }
            else
            {
                btn.Text = "O"; // Define o texto do botão como "O"
                vez = "x"; // Muda a vez para "x"
            }

            // Verifica se "x" ganhou em diferentes combinações
            if (btn10.Text == "x" && btn11.Text == "x" && btn12.Text == "x")
            {
                // Exibe um alerta informando que "x" ganhou
                DisplayAlert("Parabéns", "O X ganhou", "OK");
                zerar(); // Chama o método para reiniciar o jogo
            }
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' Ganhou", "OK");
                zerar();
            }
            else if (btn10.Text == "x" && btn20.Text == "x" && btn30.Text == "x")
            {
                DisplayAlert("Parabéns", "O 'X' ganhou", "ok");
                zerar();
            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' Ganhou", "OK");
                zerar();
            }
            else if (btn10.Text == "x" && btn21.Text == "x" && btn32.Text == "x")
            {
                DisplayAlert("Parabéns", "O 'X' ganhou", "ok");
                zerar();
            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "x" && btn21.Text == "x" && btn30.Text == "x")
            {
                DisplayAlert("Parabéns", "O 'X' ganhou", "ok");
                zerar();
            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' ganhou", "ok");
                zerar();
            }
            else if (btn20.Text == "x" && btn21.Text == "x" && btn22.Text == "x")
            {
                DisplayAlert("Parabéns", "O 'X' ganhou", "ok");
                zerar();
            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' ganhou", "ok");
                zerar();
            }
            else if (btn30.Text == "x" && btn31.Text == "x" && btn32.Text == "x")
            {
                DisplayAlert("Parabéns", "O 'X' ganhou", "ok");
                zerar();
            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' ganhou", "ok");
                zerar();
            }
            else if (btn11.Text == "x" && btn21.Text == "x" && btn31.Text == "x")
            {
                DisplayAlert("Parabéns", "O 'X' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "x" && btn22.Text == "x" && btn32.Text == "x")
            {
                DisplayAlert("Parabéns", "O 'X' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "A 'O' ganhou", "ok");
                zerar();
            }
            else if (btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                     btn20.Text != "" && btn21.Text != "" && btn22.Text != "" &&
                     btn30.Text != "" && btn31.Text != "" && btn32.Text != "")
            {
                // Verifica se todos os botões estão preenchidos e não há ganhador
                DisplayAlert("Deu Velha", "não houve ganhador", "Reiniciar");
                zerar();
            }
        }

        // Método para reiniciar o jogo
        void zerar()
        {
            // Limpa o texto dos botões
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            // Habilita novamente os botões para que possam ser clicados novamente
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    }
} // Fim da classe MainPage e do namespace MauiAppJogoDaVelha
