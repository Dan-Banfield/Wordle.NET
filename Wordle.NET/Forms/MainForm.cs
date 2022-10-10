using Wordle.NET.Logic;
using System.Windows.Forms;

namespace Wordle.NET.Forms
{
    public partial class MainForm : Form
    {
        private GameManager gameManagerInstance;

        public Button[] slots;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            InitializeArray();

            gameManagerInstance = new GameManager(this);
            gameManagerInstance.StartNewGame();
        }

        private void q_Click(object sender, System.EventArgs e)
        {
            gameManagerInstance.SubmitCharacter('q');
        }

        private void w_Click(object sender, System.EventArgs e)
        {

        }

        private void e_Click(object sender, System.EventArgs e)
        {

        }

        private void r_Click(object sender, System.EventArgs e)
        {

        }

        private void t_Click(object sender, System.EventArgs e)
        {

        }

        private void y_Click(object sender, System.EventArgs e)
        {

        }

        private void u_Click(object sender, System.EventArgs e)
        {

        }

        private void i_Click(object sender, System.EventArgs e)
        {

        }

        private void o_Click(object sender, System.EventArgs e)
        {

        }

        private void p_Click(object sender, System.EventArgs e)
        {

        }

        private void a_Click(object sender, System.EventArgs e)
        {

        }

        private void s_Click(object sender, System.EventArgs e)
        {

        }

        private void d_Click(object sender, System.EventArgs e)
        {

        }

        private void f_Click(object sender, System.EventArgs e)
        {

        }

        private void g_Click(object sender, System.EventArgs e)
        {

        }

        private void h_Click(object sender, System.EventArgs e)
        {

        }

        private void j_Click(object sender, System.EventArgs e)
        {

        }

        private void k_Click(object sender, System.EventArgs e)
        {

        }

        private void l_Click(object sender, System.EventArgs e)
        {

        }

        private void enter_Click(object sender, System.EventArgs e)
        {

        }

        private void z_Click(object sender, System.EventArgs e)
        {

        }

        private void x_Click(object sender, System.EventArgs e)
        {

        }

        private void c_Click(object sender, System.EventArgs e)
        {

        }

        private void v_Click(object sender, System.EventArgs e)
        {

        }

        private void b_Click(object sender, System.EventArgs e)
        {

        }

        private void n_Click(object sender, System.EventArgs e)
        {

        }

        private void m_Click(object sender, System.EventArgs e)
        {

        }

        private void back_Click(object sender, System.EventArgs e)
        {
            gameManagerInstance.SubmitCharacter('-');
        }

        #endregion

        #region Methods

        private void InitializeArray()
        {
            slots = new Button[] 
            {
                slot1,
                slot2,
                slot3,
                slot4,
                slot5,
                slot6,
                slot7,
                slot8,
                slot9,
                slot10,
                slot11,
                slot12,
                slot13,
                slot14,
                slot15,
                slot16,
                slot17,
                slot18,
                slot19,
                slot20,
                slot21,
                slot22,
                slot23,
                slot24,
                slot25,
                slot26,
                slot27,
                slot28,
                slot29,
                slot30,
            };
        }

        #endregion
    }
}