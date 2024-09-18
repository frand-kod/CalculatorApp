namespace CalculatorWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //adding function
        static int Tambah(int a, int b)
        {
            return a + b;
        }
        static int Kurang(int a, int b)
        {
            return a - b;
        }
        static int Kali(int a, int b)
        {
            return a * b;
        }
        static int Bagi(int a, int b)
        {
            return a / b;
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            //casting value
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            string operasiHitung = "";//set nilai default == string kosong

            if (comboBoxOperasi.SelectedItem != null)
            {
                //casting stringindex combobox
                operasiHitung += comboBoxOperasi.SelectedItem.ToString();

                lstHasil.Items.Clear();//Bersih bersih kotak hasil ketika di klik

                //switching operation
                // Penambahan
                // Pengurangan
                // Perkalian
                // Pembagian
                switch (operasiHitung)
                {
                    case "Penambahan":
                        lstHasil.Items.Add(string.Format("Hasil Penambahan {0} dan {1} = {2}", a, b, a + b));
                        break;
                    case "Pengurangan":
                        lstHasil.Items.Add(string.Format("Hasil Pengurangan {0} dan {1} = {2}", a, b, a - b));
                        break;
                    case "Perkalian":
                        lstHasil.Items.Add(string.Format("Hasil Perkalian {0} dan {1} = {2}", a, b, a * b));
                        break;
                    case "Pembagian":
                        lstHasil.Items.Add(string.Format("Hasil Pembagian {0} dan {1} = {2}", a, b, a / b));
                        break;
                }
            }
            else
            {
                lstHasil.Items.Add("PILIH DAHULU OPERASINYA!!!...");
            }

        }

        private void bersihkan_Click(object sender, EventArgs e)
        {
            //hapus value di TextBox
            txtNilaiA.Text = string.Empty;
            txtNilaiB.Text = string.Empty;

            //hapus value di listbox
            lstHasil.Items.Clear();
        }

        //fungsi tak terpakai

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NilaiA_Click(object sender, EventArgs e)
        {

        }

        private void txtNilaiA_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
