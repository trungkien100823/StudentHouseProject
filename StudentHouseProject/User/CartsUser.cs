﻿using System.ComponentModel;

namespace StudentHouseProject.User
{
    public partial class CartsUser : UserControl
    {
        public CartsUser()
        {
            InitializeComponent();
        }

        #region Carts
        private string _title;
        private string _price;
        private Image _image;

        public delegate void RemovefromCart(CartsUser item);
        public event RemovefromCart RemoveCart;


        private void Remove_Click(object sender, EventArgs e)
        {
            RemoveCart?.Invoke(this);

        }

        private void CartsUser_Load(object sender, EventArgs e)
        {

        }

        [Category("display")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }

        }
        [Category("display")]

        public string Price
        {
            get { return _price; }
            set { _price = value; lbPrice.Text = value; }

        }


        [Category("display")]

        public Image icon
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }

        }
        #endregion Carts

    }
}
