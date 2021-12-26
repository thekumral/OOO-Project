using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Project
{
    public partial class FormCustomerProfile : Form
    {
        public FormCustomerProfile()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        { //normalde burada item sınıfının product id isini kullanmayı düşünüyoduk
          //ama form değiştirirken sürekli 0 olarak değeri dönderdi ve bu çözümü bulduk 
          //formdaki textbox ve label in modifiersini public yaparak yaptık
            FormBuyCustomer buycostomer = new FormBuyCustomer();
            buycostomer.label16.Text= txtBuyProductID.Text;
            buycostomer.ShowDialog();
            this.Hide();
        }

        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {           // DataGridView tablosunun otomatik boyutlandırması için kullanılan kod 
            //https://stackoverflow.com/questions/1025670/how-do-you-automatically-resize-columns-in-a-datagridview-control-and-allow-the 
            this.productQuantityTableAdapter.Fill(this.productQuantitys1.ProductQuantity);
            for (int i = 0; i < DGVProductQuantity.Columns.Count - 1; i++)
            {
                DGVProductQuantity.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DGVProductQuantity.Columns[DGVProductQuantity.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DGVProductQuantity.Columns.Count; i++)
            {
                int colw = DGVProductQuantity.Columns[i].Width;
                DGVProductQuantity.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DGVProductQuantity.Columns[i].Width = colw;
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
