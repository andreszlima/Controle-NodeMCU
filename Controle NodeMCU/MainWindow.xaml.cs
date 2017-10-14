using System;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Controle_NodeMCU
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool status_LED = false;
        public string topico = "";
        public string topico_Real = "statusReal";

        private void Carregado(object sender, RoutedEventArgs e)
        {
            txtHost.Text = "";
            txtPort.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            txtTopico.Text = "";
            LEDControl(0);

            txtHost.Focus ( );
        }

        static MqttClient client;

        private void btnExit_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void bConectar_Click(object sender, RoutedEventArgs e)
        {
            topico = txtTopico.Text;

            try
            {

                client = new MqttClient(txtHost.Text, int.Parse(txtPort.Text), false, MqttSslProtocols.None, null, null);
                //client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                byte code = client.Connect(Guid.NewGuid().ToString(), txtUser.Text, txtPassword.Text);
                if (code == 0)
                {
                    MessageBox.Show("Conectado de boa!", "Tudo ok!", MessageBoxButton.OK, MessageBoxImage.Information);

                    //Subcribe Topic
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    client.Subscribe(new string[] { topico_Real }, new byte[] { 0 });
                    //READ LED STATUS
                    client.Publish(topico, Encoding.UTF8.GetBytes("" + 0));
                    
                }

                else MessageBox.Show("A conexão falhou");
            }

            catch (Exception)
            {
                MessageBox.Show("Pelo menos uma caixa de texto dessas tem alguma informação errada", "Algo está errado!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        Action<string, string> ReceiveAction;
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ReceiveAction = Receive;
            try
            {
                Dispatcher.BeginInvoke(ReceiveAction, Encoding.UTF8.GetString(e.Message), e.Topic);
            }
            catch { };
        }

        void Receive(string message, string topic)
        {

            if (topic == topico_Real)
            {
                byte status = byte.Parse(message);
                LEDControl(status);
                return;
                
            }
            
        }

        private void bSwitch_Click(object sender, RoutedEventArgs e)
        {
            if (status_LED)
            {
                client.Publish(topico, Encoding.UTF8.GetBytes("0"));
            }
            else
            {
                client.Publish(topico, Encoding.UTF8.GetBytes("1"));
            }
        }

        void LEDControl(byte status)
        {
            byte[] led = new byte[1];
            led[0] = (byte)((status) & 0x01);
            if (led[0] == 1)
            {
                image.Source = new BitmapImage(new Uri(@"/Imagens/ligada.jpg", UriKind.Relative));
                status_LED = true;
                bSwitch.Content = "Desligar";
            }
            else
            {
                image.Source = new BitmapImage(new Uri(@"/Imagens/desligada.jpg", UriKind.Relative));
                status_LED = false;
                bSwitch.Content = "Ligar";
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            try
            {
                client.Disconnect();
            }
            catch (Exception)
            {
                
            }
            

            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void bMudarTopico_Click(object sender, RoutedEventArgs e)
        {
            topico = txtTopico.Text;
        }
    }
}
