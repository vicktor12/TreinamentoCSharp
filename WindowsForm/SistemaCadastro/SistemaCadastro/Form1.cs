namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            boxMaritalStatus.Items.Add("Casado");
            boxMaritalStatus.Items.Add("Solteiro");
            boxMaritalStatus.Items.Add("Divorciado");
            boxMaritalStatus.Items.Add("Viuvo");

            boxMaritalStatus.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = -1;
            char gender;

            foreach (Pessoa p in pessoas)
            {
                if (p.Name == boxName.Text)
                {
                    index = pessoas.IndexOf(p);
                }
            }

            if(boxName.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.");
                boxName.Focus();
                return;
            }

            if (boxPhone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone.");
                boxPhone.Focus();
                return;
            }


            if(radioM.Checked)
            {
                gender = 'M';
            } 
            else if(radioW.Checked)
            {
                gender = 'F';
            } 
            else
            {
                gender = 'O';
            }

            Pessoa pessoa = new Pessoa();
            pessoa.Name = boxName.Text;
            pessoa.Birthday = boxDate.Text;
            pessoa.MaritalStatus = boxMaritalStatus.SelectedItem.ToString();
            pessoa.Phone = boxPhone.Text;
            pessoa.House = checkHouse.Checked;
            pessoa.Car = checkCar.Checked;
            pessoa.Gender = gender;

            if(index < 0)
            {
                pessoas.Add(pessoa);
            }
            else
            {
                pessoas[index] = pessoa;
            }

            btnClear_Click(btnClear, EventArgs.Empty);

            Listar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            btnClear_Click(btnClear, EventArgs.Empty);
            Listar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            boxName.Text = "";
            boxDate.Text = "";
            boxMaritalStatus.SelectedIndex = 0;
            boxPhone.Text = "";
            checkHouse.Checked = false;
            checkCar.Checked = false;
            radioM.Checked = true;
            radioW.Checked = false;
            radioO.Checked = false;
            boxName.Focus();
        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa pessoa in pessoas)
            {
                lista.Items.Add(pessoa.Name);
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lista.SelectedIndex;
            Pessoa pessoa = pessoas[index];

            boxName.Text = pessoa.Name;
            boxDate.Text = pessoa.Birthday;
            boxMaritalStatus.SelectedItem = pessoa.MaritalStatus;
            boxPhone.Text = pessoa.Phone;
            checkHouse.Checked = pessoa.House;
            checkCar.Checked = pessoa.Car;


            switch (pessoa.Gender)
            {
                case 'M':
                    radioM.Checked = true;
                    break;
                case 'F':
                    radioW.Checked = true;
                    break;
                default:
                    radioO.Checked= true;
                    break;
            }
        }
    }
}