using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        private PointsDiscount point = new PointsDiscount();

        private PercentDiscount percent = new PercentDiscount(Category.Сables);

        public List<Item> Items { get; set; }

        public DiscountsTab()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {      
            DiscountAmountNumberLabel.Text = point.Calculate(Items).ToString();
            InfoDiscountLabel.Text = point.Info;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DiscountAmountNumberLabel.Text = point.Apply(Items).ToString();
            InfoDiscountLabel.Text = point.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            point.Update(Items);
            InfoDiscountLabel.Text = point.Info;
        }

        private void DiscountsTab_Load(object sender, EventArgs e)
        {
            double amount = 0;
            //foreach (var item in Items)
            //{
            //    amount += item.Cost;
            //}
            ProductsAmountNumberLabel.Text = amount.ToString();
            ProductsAmountPercentNumberLabel.Text = amount.ToString();
        }

        private void CalculatePercentButton_Click(object sender, EventArgs e)
        {
            DiscountAmountPercentNumberLabel.Text = percent.Calculate(Items).ToString();
            InfoDiscountPercentLabel.Text = percent.Info;
        }

        private void ApplyPercentButton_Click(object sender, EventArgs e)
        {
            DiscountAmountPercentNumberLabel.Text = percent.Apply(Items).ToString();
            InfoDiscountPercentLabel.Text = percent.Info;
        }

        private void UpdatePercentButton_Click(object sender, EventArgs e)
        {
            percent.Update(Items);
            InfoDiscountPercentLabel.Text = percent.Info;
        }
    }
}
