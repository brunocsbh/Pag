using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Controls;
using Pag_Negocio.Mensagens;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Pag_Gerenciador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Carrega_cmbTipoConsumidor();
        }

        protected void Carrega_cmbTipoConsumidor()
        {
            ComboboxItem itemMesa = new ComboboxItem();
            itemMesa.Text = "Mesa";
            itemMesa.Value = 1;

            ComboboxItem itemCartao = new ComboboxItem();
            itemCartao.Text = "Cartão Individual";
            itemCartao.Value = 2;

            cmbTipoConsumidor.Items.Add(itemMesa);
            cmbTipoConsumidor.Items.Add(itemCartao);

            cmbTipoConsumidor.SelectedIndex = 0;
        }

        private void btnGerarQrcode_Click(object sender, EventArgs e)
        {
            var consumidor = GerarConsumidor(true);
            if (consumidor != null && consumidor.qrCode != null && !string.IsNullOrEmpty(consumidor.qrCode))
                gen_qr_show(consumidor.qrCode);

        }

        //Gera QR e salva arquivo
        //private void gen_qr_file(string file_name, string content, int image_size)
        //{
        //    string new_file_name = file_name;

        //    QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
        //    QrCode qrCode = new QrCode();
        //    qrEncoder.TryEncode(content, out qrCode);

        //    Renderer renderer = new Renderer(image_size, Brushes.Black, Brushes.White);

        //    MemoryStream ms = new MemoryStream();

        //    renderer.WriteToStream(qrCode.Matrix, ms, ImageFormat.Png);

        //    var imageTemp = new Bitmap(ms);

        //    var image = new Bitmap(imageTemp, new Size(new Point(200, 200)));

        //    image.Save(new_file_name + ".png", ImageFormat.Png);
        //}

        //Gera QR e exibe na tela
        private void gen_qr_show(string conteudoQrCode)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(conteudoQrCode, out qrCode);

            Renderer renderer = new Renderer(200, Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ms, ImageFormat.Png);

            var imageTemp = new Bitmap(ms);

            var image = new Bitmap(imageTemp, new Size(new Point(200, 200)));

            picBoxCode.Image = image;

            lblConteudoQrCode.Text = conteudoQrCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerarConsumidor(false);

        }

        private Consumidor GerarConsumidor(bool apenasQrCode)
        {
            Pag_Negocio.Mensagens.Consumidor consumidor = null;

            try
            {
                if (string.IsNullOrEmpty(txtIdConsumidor.Text))
                    throw new Exception("Campo ID Consumidor obrigatório.");

                consumidor = new Pag_Negocio.Mensagens.Consumidor();
                consumidor.consumidorTipo = int.Parse((cmbTipoConsumidor.SelectedItem as ComboboxItem).Value.ToString());
                consumidor.consumidorId = txtIdConsumidor.Text;

                if (!apenasQrCode)
                {
                    var consumidorService = new Pag_Negocio.ConsumidorService();
                    consumidorService.GerarConsumidor(consumidor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return consumidor;
        }

        private void btnGerarQrcodeArquivo_Click(object sender, EventArgs e)
        {

        }
    }
}
