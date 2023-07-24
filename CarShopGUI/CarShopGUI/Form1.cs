using CarClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSourse = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            // MessageBox.Show(c.ToString());
            myStore.CarList.Add(c);
            carInventoryBindingSourse.ResetBindings(false);
            txt_make.Text = "";
            txt_model.Text = "";
            txt_price.Text = "";

        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            // get the selected item from inventory
            Car selected = (Car)lst_inventory.SelectedItem;
            // add the item to the cart
            myStore.ShoppingList.Add(selected);
            // update the list box control
            cartBindingSource.ResetBindings(false);


        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$ " + total.ToString();

            cartBindingSource.ResetBindings(false);
        }

        private void lst_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSourse.DataSource = myStore.CarList;
            cartBindingSource.DataSource = myStore.ShoppingList;
            lst_inventory.DataSource = carInventoryBindingSourse;
            lst_inventory.ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.ToString();
        }
    }
}