using FormProgramCamadas.Code.BLL;
using FormProgramCamadas.Code.DTO;
using System.Globalization;

namespace FormProgramCamadas//Camada de apresentação
{
    public partial class frmCadastroCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();
        ClienteDTO dto = new ClienteDTO();
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //preenchendo o objeto de acordo com o que o usuário digitou
            dto.Nome = txtNome.Text;
            dto.Email = txtEmail.Text;
            dto.CPF = txtCPF.Text;
            try
            {
                dto.DataNascimento = DateTime.ParseExact(txtDataNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("A data de nascimento não está no formato correto. Use dd/MM/yyyy.");
            }

            //invocando o método inserir da camada de negócios para gravar no banco de dados
            bll.Inserir(dto);
        }

    }
}