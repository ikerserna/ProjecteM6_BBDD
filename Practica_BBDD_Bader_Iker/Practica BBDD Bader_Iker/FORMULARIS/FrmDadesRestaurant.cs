using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    public partial class FrmDadesRestaurant : Form
    {
        public FrmDadesRestaurant()
        {
            InitializeComponent();
        }

        private async void btnPreview_Click(object sender, EventArgs e)
        {
            string url = tbEnllacWeb.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor ingresa una URL.");
                return;
            }

            var image = await CapturaPreviewAsync(url);
            pbWeb.Image = image;
        }

        private async Task<Image> CapturaPreviewAsync(string url)
        {
            var webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;
            Controls.Add(webView2);

            await webView2.EnsureCoreWebView2Async();

            webView2.CoreWebView2.Navigate(url);

            await Task.Delay(3000);

            Bitmap bitmap = new Bitmap(webView2.Width, webView2.Height);
            webView2.DrawToBitmap(bitmap, new Rectangle(0, 0, webView2.Width, webView2.Height));

            Controls.Remove(webView2);

            return bitmap;
        }
    }
}
