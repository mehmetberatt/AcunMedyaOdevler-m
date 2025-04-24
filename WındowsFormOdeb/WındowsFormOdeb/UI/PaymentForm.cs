using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WındowsFormOdeb.Business;

namespace WındowsFormOdeb.UI
{
    public partial class PaymentForm: Form
    {

        public PaymentForm() => InitializeComponent();

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            cmbOdeme.DataSource = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t)
                            && t.IsClass && !t.IsAbstract)
                .ToList();
            cmbOdeme.DisplayMember = "Name";
        }

        private void btnOde_Click(object sender, EventArgs e)

        {
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");

                if (cmbOdeme.SelectedItem is Type secilenTip &&
                    decimal.TryParse(txtTutar.Text, out decimal tutar))
                {
                    var nesne = Activator.CreateInstance(secilenTip) as IOdemeYontemi;

                    if (nesne != null)
                    {
                        string sonuc = nesne.Ode(tutar);
                        lblSonuc.Text = sonuc;
                        lblSonuc.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblSonuc.Text = "Nesne oluşturulamadı.";
                        lblSonuc.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblSonuc.Text = "Geçerli bir tutar girin ve ödeme yöntemi seçin.";
                    lblSonuc.ForeColor = Color.Red;
                }
            }
            }

        private void btnOde_Click_1(object sender, EventArgs e)
        {
          
        }

        private void cmbOdeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
