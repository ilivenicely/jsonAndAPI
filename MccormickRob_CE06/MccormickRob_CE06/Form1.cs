//Robert Mccormick
//Frameworks
//Term3
//RobertMcCormick_CE08



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeListApp.Models;

namespace TreeListApp
{
    public partial class Form1 : Form
    {
        private decimal totalMiles;
        private decimal totalHours;
        private decimal totalLegs;

        public Form1()
        {
            InitializeComponent();
            //add default value for direction combobox
            cbbDirection.Items.Add(new ComboItem() { Text = "NoWhere", Value = Enums.DirectionEnum.NoWhere});
            cbbDirection.Items.Add(new ComboItem() { Text = "East", Value = Enums.DirectionEnum.East });
            cbbDirection.Items.Add(new ComboItem() { Text = "West", Value = Enums.DirectionEnum.West });
            cbbDirection.Items.Add(new ComboItem() { Text = "North", Value = Enums.DirectionEnum.North });
            cbbDirection.Items.Add(new ComboItem() { Text = "South", Value = Enums.DirectionEnum.South });
            
            SetDefaultValue();
        }

        private void SetDefaultValue()
        {
            totalHours = 0;
            totalLegs = 0;
            totalMiles = 0;
            trvResult.Nodes.Clear();

            cbbDirection.SelectedIndex = 0;
            txtMode.Text = String.Empty;
            txtTotalHours.Text = "0.00";
            txtTotalLegs.Text = "0";
            txtTotalMiles.Text = "0.00";
            numHours.Value = 0;
            numMiles.Value = 0;
        }

        //event when user clicks new menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resets all data
            SetDefaultValue();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if direction = nowhere
            if(cbbDirection.SelectedIndex == 0)
            {
                //do nothing
                return;
            }

            //add node to treeview
            var tripNode = new TreeNode();
            tripNode.Text = (cbbDirection.SelectedItem as ComboItem).Text;
            tripNode.ImageIndex = cbbDirection.SelectedIndex;
            tripNode.SelectedImageIndex = 0;

            //add child node
            var mileNode = new TreeNode();
            mileNode.Text = String.Format("Miles: {0:0.00}", numMiles.Value);
            mileNode.ImageIndex = 5;
            mileNode.SelectedImageIndex = 0;

            var hourNode = new TreeNode();
            hourNode.Text = String.Format("Hours: {0:0.00}", numHours.Value);
            hourNode.ImageIndex = 6;
            hourNode.SelectedImageIndex = 0;

            var modeNode = new TreeNode();
            modeNode.Text = String.Format("Mode: {0}", txtMode.Text);
            modeNode.ImageIndex = 7;
            modeNode.SelectedImageIndex = 0;

            tripNode.Nodes.Add(mileNode);
            tripNode.Nodes.Add(hourNode);
            tripNode.Nodes.Add(modeNode);
            trvResult.Nodes.Add(tripNode);

            //update Total tab data
            totalHours += numHours.Value; 
            totalMiles += numMiles.Value;
            totalLegs++;

            txtTotalHours.Text = string.Format("{0:0.00}", totalHours);
            txtTotalMiles.Text = string.Format("{0:0.00}", totalMiles);
            txtTotalLegs.Text = string.Format("{0}", totalLegs);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
