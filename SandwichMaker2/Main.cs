using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SandwichMaker2
{
    public partial class Main : Form
    {
        Sandwich sandwich;

        public Main()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            LayoutTable.Location = new Point((Screen.PrimaryScreen.Bounds.Width - LayoutTable.Width - ChoiseContainer.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - LayoutTable.Height) / 2);
            ChoiseContainer.Location = new Point((Screen.PrimaryScreen.Bounds.Width + LayoutTable.Width - ChoiseContainer.Width + 5) / 2, (Screen.PrimaryScreen.Bounds.Height - LayoutTable.Height) / 2);

            CloseButton.Location = new Point(ChoiseContainer.Location.X + ChoiseContainer.Width - CloseButton.Width, 50);
            SettingsButton.Location = new Point(ChoiseContainer.Location.X + ChoiseContainer.Width - CloseButton.Width - 10 - SettingsButton.Width, 50);

            sandwich = new Sandwich();
            UpdateIngredientList();

        }

        private Point GetMousePosition() {
            Point P = Main.MousePosition;
            return P;
        }

        private void DragProduct() {

        }

        private void OpenUserForm()
        {

        }

        private void CloseApplication(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }

        private void IngredientClicked(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            switch (p.Name)
            {
                case "Ingredient1":
                    sandwich.AddProduct(1);
                    break;
                case "Ingredient2":
                    sandwich.AddProduct(2);
                    break;
                case "Ingredient3":
                    sandwich.AddProduct(3);
                    break;
                case "Ingredient4":
                    sandwich.AddProduct(4);
                    break;
                case "Ingredient5":
                    sandwich.AddProduct(5);
                    break;
                case "Ingredient6":
                    sandwich.AddProduct(6);
                    break;
                case "Ingredient7":
                    sandwich.AddProduct(7);
                    break;
                case "Ingredient8":
                    sandwich.AddProduct(8);
                    break;
                case "Ingredient9":
                    sandwich.AddProduct(9);
                    break;
                case "Ingredient10":
                    sandwich.AddProduct(10);
                    break;
                case "Ingredient11":
                    sandwich.AddProduct(11);
                    break;
                case "Ingredient12":
                    sandwich.AddProduct(12);
                    break;

            }
            UpdateIngredientList();
        }

        public void UpdateIngredientList()
        {
            UpdateImage(Choise10, sandwich.GetConstruction(0));
            UpdateImage(Choise9, sandwich.GetConstruction(1));
            UpdateImage(Choise8, sandwich.GetConstruction(2));
            UpdateImage(Choise7, sandwich.GetConstruction(3));
            UpdateImage(Choise6, sandwich.GetConstruction(4));
            UpdateImage(Choise5, sandwich.GetConstruction(5));
            UpdateImage(Choise4, sandwich.GetConstruction(6));
            UpdateImage(Choise3, sandwich.GetConstruction(7));
            UpdateImage(Choise2, sandwich.GetConstruction(8));
            UpdateImage(Choise1, sandwich.GetConstruction(9));

        }

        public void UpdateImage(PictureBox p, int ingredient)
        {
            switch (ingredient)
            {
                case 0:
                    p.Image = null;
                    break;
                case 1:
                    p.Image = SandwichMaker2.Properties.Resources._1;
                    break;
                case 2:
                    p.Image = SandwichMaker2.Properties.Resources._2;
                    break;
                case 3:
                    p.Image = SandwichMaker2.Properties.Resources._3;
                    break;
                case 4:
                    p.Image = SandwichMaker2.Properties.Resources._4;
                    break;
                case 5:
                    p.Image = SandwichMaker2.Properties.Resources._5;
                    break;
                case 6:
                    p.Image = SandwichMaker2.Properties.Resources._6;
                    break;
                case 7:
                    p.Image = SandwichMaker2.Properties.Resources._7;
                    break;
                case 8:
                    p.Image = SandwichMaker2.Properties.Resources._8;
                    break;
                case 9:
                    p.Image = SandwichMaker2.Properties.Resources._9;
                    break;
                case 10:
                    p.Image = SandwichMaker2.Properties.Resources._10;
                    break;
                case 11:
                    p.Image = SandwichMaker2.Properties.Resources._11;
                    break;
                case 12:
                    p.Image = SandwichMaker2.Properties.Resources._12;
                    break;
                case 100:
                    p.Image = SandwichMaker2.Properties.Resources._0;
                    break;
                case 200:
                    p.Image = SandwichMaker2.Properties.Resources._0;
                    break;

            }
        }

        private void delProduct(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            switch (p.Name)
            {
                case "delProduct1":
                    sandwich.DeleteProduct(10);
                    break;
                case "delProduct2":
                    sandwich.DeleteProduct(9);
                    break;
                case "delProduct3":
                    sandwich.DeleteProduct(8);
                    break;
                case "delProduct4":
                    sandwich.DeleteProduct(7);
                    break;
                case "delProduct5":
                    sandwich.DeleteProduct(6);
                    break;
                case "delProduct6":
                    sandwich.DeleteProduct(5);
                    break;
                case "delProduct7":
                    sandwich.DeleteProduct(4);
                    break;
                case "delProduct8":
                    sandwich.DeleteProduct(3);
                    break;
                case "delProduct9":
                    sandwich.DeleteProduct(2);
                    break;
                case "delProduct10":
                    sandwich.DeleteProduct(1);
                    break;

            }
            UpdateIngredientList();
        }

        private void MoveProductUp(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            switch (p.Name)
            {
                case "upProduct1":
                    sandwich.MoveProductUp(10);
                    break;
                case "upProduct2":
                    sandwich.MoveProductUp(9);
                    break;
                case "upProduct3":
                    sandwich.MoveProductUp(8);
                    break;
                case "upProduct4":
                    sandwich.MoveProductUp(7);
                    break;
                case "upProduct5":
                    sandwich.MoveProductUp(6);
                    break;
                case "upProduct6":
                    sandwich.MoveProductUp(5);
                    break;
                case "upProduct7":
                    sandwich.MoveProductUp(4);
                    break;
                case "upProduct8":
                    sandwich.MoveProductUp(3);
                    break;
                case "upProduct9":
                    sandwich.MoveProductUp(2);
                    break;
                case "upProduct10":
                    sandwich.MoveProductUp(1);
                    break;

            }
            UpdateIngredientList();
        }

        private void MoveProductDown(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            switch (p.Name)
            {
                case "downProduct1":
                    sandwich.MoveProductDown(10);
                    break;
                case "downProduct2":
                    sandwich.MoveProductDown(9);
                    break;
                case "downProduct3":
                    sandwich.MoveProductDown(8);
                    break;
                case "downProduct4":
                    sandwich.MoveProductDown(7);
                    break;
                case "downProduct5":
                    sandwich.MoveProductDown(6);
                    break;
                case "downProduct6":
                    sandwich.MoveProductDown(5);
                    break;
                case "downProduct7":
                    sandwich.MoveProductDown(4);
                    break;
                case "downProduct8":
                    sandwich.MoveProductDown(3);
                    break;
                case "downProduct9":
                    sandwich.MoveProductDown(2);
                    break;
                case "downProduct10":
                    sandwich.MoveProductDown(1);
                    break;

            }
            UpdateIngredientList();
        }

    }
}
