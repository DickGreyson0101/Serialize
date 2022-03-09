namespace serialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<sinhvien> dssv = new List<sinhvien>();
        private void button1_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.Ma = textBox1.Text;
            sv.ten = textBox2.Text;
            sv.nmm = (float)numericUpDown1.Value;
            sv.lthdt = (float)numericUpDown2.Value;
            sv.csdl = (float)numericUpDown3.Value;
            sv.dtb = (sv.nmm + sv.lthdt + sv.csdl) / 3;
            dssv.Add(sv);
            HienThiListbox();


        }

        private void HienThiListbox()
        {
        listSV.Items.Clear();
            foreach (sinhvien sv in dssv)
            {
                listSV.Items.Add(sv);
            }    
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.text";
            bool kt = Dataluufile.luufile(dssv,path);
            if (kt==true)
            {
                MessageBox.Show("Lưu thành công");
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.text";
            dssv = Dataluufile.Docfile(path);
            HienThiListbox();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}