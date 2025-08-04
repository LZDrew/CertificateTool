using System;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;

namespace CertificateTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCountryCodes();
        }
        private void LoadCountryCodes()
        {
            string[] isoCountries = new string[]
            {
        "AF", "AL", "DZ", "AS", "AD", "AO", "AI", "AQ", "AG", "AR", "AM", "AW", "AU", "AT", "AZ",
        "BS", "BH", "BD", "BB", "BY", "BE", "BZ", "BJ", "BM", "BT", "BO", "BA", "BW", "BR", "BN",
        "BG", "BF", "BI", "KH", "CM", "CA", "CV", "KY", "CF", "TD", "CL", "CN", "CO", "KM", "CG",
        "CD", "CR", "CI", "HR", "CU", "CY", "CZ", "DK", "DJ", "DM", "DO", "EC", "EG", "SV", "GQ",
        "ER", "EE", "SZ", "ET", "FJ", "FI", "FR", "GA", "GM", "GE", "DE", "GH", "GR", "GD", "GT",
        "GN", "GW", "GY", "HT", "HN", "HU", "IS", "IN", "ID", "IR", "IQ", "IE", "IL", "IT", "JM",
        "JP", "JO", "KZ", "KE", "KI", "KR", "KW", "KG", "LA", "LV", "LB", "LS", "LR", "LY", "LI",
        "LT", "LU", "MG", "MW", "MY", "MV", "ML", "MT", "MH", "MR", "MU", "MX", "FM", "MD", "MC",
        "MN", "ME", "MA", "MZ", "MM", "NA", "NR", "NP", "NL", "NZ", "NI", "NE", "NG", "MK", "NO",
        "OM", "PK", "PW", "PA", "PG", "PY", "PE", "PH", "PL", "PT", "QA", "RO", "RU", "RW", "KN",
        "LC", "VC", "WS", "SM", "ST", "SA", "SN", "RS", "SC", "SL", "SG", "SK", "SI", "SB", "SO",
        "ZA", "SS", "ES", "LK", "SD", "SR", "SE", "CH", "SY", "TW", "TJ", "TZ", "TH", "TL", "TG",
        "TO", "TT", "TN", "TR", "TM", "TV", "UG", "UA", "AE", "GB", "US", "UY", "UZ", "VU", "VE",
        "VN", "YE", "ZM", "ZW"
            };

            cmbCountry.Items.Clear(); // 保險起見先清空
            cmbCountry.Items.AddRange(isoCountries);
            cmbCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDown; // 可打字又可選擇
        }



        private void btnGenerateCSR_Click(object sender, EventArgs e)
        {
            try
            {
                string subject = $"CN={txtCN.Text}, O={txtO.Text}, OU={txtOU.Text}, C={(cmbCountry.SelectedItem as CountryItem)?.Code ?? ""}, ST={txtST.Text}, L={txtL.Text}";
                int keySize = int.Parse(cmbKeySize.SelectedItem.ToString());
                string savePath = txtSavePath.Text;
                string password = txtKeyPassword.Text;

                CsrGenerator.GenerateCsrAndKey(subject, keySize, savePath, password);

                MessageBox.Show("已成功產生 CSR 與私鑰！", "成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤：{ex.Message}");
            }
        }
        private void btnBrowseSave_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSavePath.Text = dialog.SelectedPath;
                }
            }
        }
        private void btnBrowseCert_Click(object sender, EventArgs e)
        {
            txtCertPath.Text = BrowseFile("主憑證 (*.crt;*.pem)|*.crt;*.pem|所有檔案 (*.*)|*.*");
        }

        private void btnBrowseKey_Click(object sender, EventArgs e)
        {
            txtKeyPath.Text = BrowseFile("私鑰 (*.key)|*.key|所有檔案 (*.*)|*.*");
        }

        private void btnBrowseIntermediate_Click(object sender, EventArgs e)
        {
            txtIntermediate.Text = BrowseFile("中繼憑證 (*.crt;*.pem)|*.crt;*.pem|所有檔案 (*.*)|*.*");
        }

        private void btnBrowsePfxOutput_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "PFX 憑證 (*.pfx)|*.pfx";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtPfxOutput.Text = dialog.FileName;
                }
            }
        }

        private void btnBuildPFX_Click(object sender, EventArgs e)
        {
            try
            {
                PfxBuilder.BuildPfx(
                    txtCertPath.Text,
                    txtKeyPath.Text,
                    txtPfxOutput.Text,
                    txtPfxPassword.Text,
                    string.IsNullOrEmpty(txtIntermediate.Text) ? null : txtIntermediate.Text
                );

                MessageBox.Show("PFX 合成成功！", "成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤：{ex.Message}", "錯誤");
            }
        }

        private string BrowseFile(string filter)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = filter;
                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : "";
            }
        }


    }
}
public class CountryItem
{
    public string Code { get; set; }   // e.g. TW
    public string Name { get; set; }   // e.g. 台灣

    public override string ToString()
    {
        return $"{Name} ({Code})";
    }
}
