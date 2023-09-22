using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class Form1 : Form
    {
        List<Apartment> apartments = new List<Apartment>();
        public Form1()
        {
            InitializeComponent();
        }

        private void lstvCK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string address, direction, status ;
            int price, bedroom, toilet, discount;
            address = txbAddress.Text;
            direction = txbDirection.Text;
            status = txbStatus.Text;
            price = int.Parse(txbPrice.Text);
            bedroom = int.Parse(txbBedroom.Text);
            toilet = int.Parse(txbToilet.Text);
            
            Apartment apartment = new Apartment(address, direction, status, price, bedroom, toilet);
            discount = apartment.getDiscountPrice();
            apartments.Add(apartment);
            ListViewItem item = new ListViewItem();
            item.Text = address;
            item.SubItems.Add(bedroom.ToString());
            item.SubItems.Add(toilet.ToString());
            item.SubItems.Add(direction);
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(discount.ToString());
            item.SubItems.Add(status);
            lstvCK.Items.Add(item);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to make changes?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int i = lstvCK.SelectedItems[0].Index;
                if(i >= 0)
                {
                    lstvCK.Items[i].SubItems[0].Text = txbAddress.Text;
                    lstvCK.Items[i].SubItems[1].Text = txbBedroom.Text;
                    lstvCK.Items[i].SubItems[2].Text = txbToilet.Text;
                    lstvCK.Items[i].SubItems[3].Text = txbDirection.Text;
                    lstvCK.Items[i].SubItems[4].Text = txbPrice.Text;
                    int discount = 0;
                    if (txbDirection.Text.Equals("West"))
                    {
                        discount = -10;
                    }
                    else if (txbDirection.Text.Equals("North West"))
                    {
                        discount = -5;
                    }
                    else if (txbDirection.Text.Equals("South West"))
                    {
                        discount = -2;
                    }
                    else if (txbDirection.Text.Equals("South East"))
                    {
                        discount = 1;
                    }
                    int discountPrice = int.Parse(txbPrice.Text) + (int.Parse(txbPrice.Text) * discount) / 100;

                    lstvCK.Items[i].SubItems[5].Text = discountPrice.ToString();
                    lstvCK.Items[i].SubItems[6].Text = txbStatus.Text;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstvCK.SelectedItems.Count > 0)
            {
                int i = lstvCK.SelectedItems[0].Index;
                if(MessageBox.Show("Do you really want to delete?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstvCK.Items.RemoveAt(i);
                }
            }
        }
    }
}
