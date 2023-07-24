namespace CarShopGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txt_price = new TextBox();
            txt_model = new TextBox();
            txt_make = new TextBox();
            btn_create_car = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lst_inventory = new ListBox();
            groupBox3 = new GroupBox();
            lst_cart = new ListBox();
            label4 = new Label();
            lbl_total = new Label();
            btn_addtocart = new Button();
            btn_checkout = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_price);
            groupBox1.Controls.Add(txt_model);
            groupBox1.Controls.Add(txt_make);
            groupBox1.Controls.Add(btn_create_car);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(73, 153);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(125, 27);
            txt_price.TabIndex = 6;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(73, 100);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(125, 27);
            txt_model.TabIndex = 5;
            // 
            // txt_make
            // 
            txt_make.Location = new Point(73, 51);
            txt_make.Name = "txt_make";
            txt_make.Size = new Size(125, 27);
            txt_make.TabIndex = 4;
            // 
            // btn_create_car
            // 
            btn_create_car.Location = new Point(13, 201);
            btn_create_car.Name = "btn_create_car";
            btn_create_car.Size = new Size(173, 29);
            btn_create_car.TabIndex = 3;
            btn_create_car.Text = "Create a Car";
            btn_create_car.UseVisualStyleBackColor = true;
            btn_create_car.Click += btn_create_car_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 153);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 103);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 51);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Make:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lst_inventory);
            groupBox2.Location = new Point(271, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 390);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lst_inventory
            // 
            lst_inventory.FormattingEnabled = true;
            lst_inventory.ItemHeight = 20;
            lst_inventory.Location = new Point(18, 43);
            lst_inventory.Name = "lst_inventory";
            lst_inventory.Size = new Size(197, 324);
            lst_inventory.TabIndex = 0;
            lst_inventory.SelectedIndexChanged += lst_inventory_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lst_cart);
            groupBox3.Location = new Point(642, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 263);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // lst_cart
            // 
            lst_cart.FormattingEnabled = true;
            lst_cart.ItemHeight = 20;
            lst_cart.Location = new Point(18, 43);
            lst_cart.Name = "lst_cart";
            lst_cart.Size = new Size(188, 204);
            lst_cart.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(630, 382);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Total Cost:";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(723, 382);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(44, 20);
            lbl_total.TabIndex = 4;
            lbl_total.Text = "$0.00";
            // 
            // btn_addtocart
            // 
            btn_addtocart.Location = new Point(523, 187);
            btn_addtocart.Name = "btn_addtocart";
            btn_addtocart.Size = new Size(94, 29);
            btn_addtocart.TabIndex = 5;
            btn_addtocart.Text = "Add a Car";
            btn_addtocart.UseVisualStyleBackColor = true;
            btn_addtocart.Click += btn_addtocart_Click;
            // 
            // btn_checkout
            // 
            btn_checkout.Location = new Point(711, 316);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(94, 29);
            btn_checkout.TabIndex = 6;
            btn_checkout.Text = "Checkout";
            btn_checkout.UseVisualStyleBackColor = true;
            btn_checkout.Click += btn_checkout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 450);
            Controls.Add(btn_checkout);
            Controls.Add(btn_addtocart);
            Controls.Add(lbl_total);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_make;
        private Button btn_create_car;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox lst_inventory;
        private GroupBox groupBox3;
        private ListBox lst_cart;
        private Label label4;
        private Label lbl_total;
        private Button btn_addtocart;
        private TextBox txt_price;
        private TextBox txt_model;
        private Button btn_checkout;
    }
}