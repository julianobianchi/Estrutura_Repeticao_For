namespace Estrutura_Repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            int num, cont, tab;
            num = Convert.ToInt16(txtNum.Text);

            for (cont = 0; cont <= 10; cont++)
            {
                tab = num * cont;
                ltbTabuada.Items.Add(num.ToString() + " * " + cont.ToString() + " = " + tab.ToString());
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            ltbTabuada.Items.Clear();
        }
    }
}