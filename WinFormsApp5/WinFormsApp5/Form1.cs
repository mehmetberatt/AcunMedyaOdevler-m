namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki verileri al
            string marka = lblMarka.Text;
            string model = lblModel.Text;
            string renk = lblRenk.Text;
            string kapiSayisi = lblKapi.Text;
            string pencereSayisi = lblPencere.Text;
            string yakit = lblYakit.Text;

            // Bilgileri mesaj kutusunda göster
            string mesaj = $"🚘 Marka: {marka}\n" +
                           $"📅 Model: {model}\n" +
                           $"🎨 Renk: {renk}\n" +
                           $"🚪 Kapı Sayısı: {kapiSayisi}\n" +
                           $"🪟 Pencere Sayısı: {pencereSayisi}\n" +
                           $"⛽ 100 km’de Yakıt: {yakit} Litre";

            MessageBox.Show(mesaj, "Araba Bilgileri");
        }
    }
}
