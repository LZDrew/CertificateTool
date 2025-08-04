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

            toolTip1.SetToolTip(picInfoCSRPage,
                "�o�ӭ����|���ͤ@�աG\n" +
                "1. �p�_ (.key)�G�i�[�K�A�Ч����O�s\n" +
                "2. ����ñ�p�ШD (CSR)�G���ѵ����ҳ��ñ�o����\n\n" +
                "�U��컡���G\n" +
                "- CN�G�D���W�١]�p www.example.com�^\n" +
                "- O�G��´�W�١]���q�W�^\n" +
                "- OU�G�����W�١]�i��^\n" +
                "- C�G��a�]�x�W�� TW�^\n" +
                "- ST / L�G�{�B�٩Ϋ����]�̾ڻݨD��g�^\n" +
                "- Key Size�G��ĳ 2048 �ΥH�W\n" +
                "- Key �K�X�G�p��J�A�p�_�N�[�K�A���w��"
            );
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

            cmbCountry.Items.Clear(); // �O�I�_�����M��
            cmbCountry.Items.AddRange(isoCountries);
            cmbCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDown; // �i���r�S�i���
        }



        private void btnGenerateCSR_Click(object sender, EventArgs e)
        {
            try
            {
                string subject = $"CN={txtCN.Text}, O={txtO.Text}, OU={txtOU.Text}, C={(cmbCountry.SelectedItem as CountryItem)?.Code ?? ""}, ST={txtST.Text}, L={txtL.Text}";
                int keySize = int.Parse(cmbKeySize.SelectedItem.ToString());
                string savePath = txtSavePath.Text;
                string password = passwordBoxCSR.Password;

                CsrGenerator.GenerateCsrAndKey(subject, keySize, savePath, password);

                MessageBox.Show("�w���\���� CSR �P�p�_�I", "���\");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���~�G{ex.Message}");
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
            txtCertPath.Text = BrowseFile("�D���� (*.crt;*.pem)|*.crt;*.pem|�Ҧ��ɮ� (*.*)|*.*");
        }

        private void btnBrowseKey_Click(object sender, EventArgs e)
        {
            txtKeyPath.Text = BrowseFile("�p�_ (*.key)|*.key|�Ҧ��ɮ� (*.*)|*.*");
        }

        private void btnBrowseIntermediate_Click(object sender, EventArgs e)
        {
            txtIntermediate.Text = BrowseFile("���~���� (*.crt;*.pem)|*.crt;*.pem|�Ҧ��ɮ� (*.*)|*.*");
        }

        private void btnBrowsePfxOutput_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "PFX ���� (*.pfx)|*.pfx";
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
                    passwordBoxPFX.Password,
                    string.IsNullOrEmpty(txtIntermediate.Text) ? null : txtIntermediate.Text
                );

                MessageBox.Show("PFX �X�����\�I", "���\");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���~�G{ex.Message}", "���~");
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


        private void passwordBoxWithToggle1_Load(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void btnBrowsePfxInspect_Click(object sender, EventArgs e)
        {
            string filePath = BrowseFile("PFX ���� (*.pfx)|*.pfx");
            if (!string.IsNullOrEmpty(filePath))
                txtPfxInspectPath.Text = filePath;
        }

        private void btnInspectPfx_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPfxInspectPath.Text;
                string password = passwordBoxInspect.Password;

                var report = PfxInspector.InspectPfx(path, password);
                txtPfxInfo.Text = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���~�G{ex.Message}");
            }
        }

        private void lblPfxPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblIntermediate_Click(object sender, EventArgs e)
        {

        }

        private void lblKeySize_Click(object sender, EventArgs e)
        {

        }
    }
}
public class CountryItem
{
    public string Code { get; set; }   // e.g. TW
    public string Name { get; set; }   // e.g. �x�W

    public override string ToString()
    {
        return $"{Name} ({Code})";
    }
}
