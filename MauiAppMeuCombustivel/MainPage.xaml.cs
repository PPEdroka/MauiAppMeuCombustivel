namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double etanol, gasolina;
            string msg;
            
            etanol = Convert.ToDouble(txtEtanol.Text);
            gasolina = Convert.ToDouble(txtGasolina.Text);

            gasolina = gasolina * 0.7;
            msg = "Marca: " + txtMarca.Text + " - " + "Modelo: " + txtModelo.Text + " - ";

            if (etanol >= gasolina)
            {
                msg = msg + "Usa gasolina!";
            }
            else
            {
                msg = msg + "Usa etanol!";
            }
            DisplayAlert("Atenção", msg, "Fechar");

        }
    }

}
