using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace ScrollBarAppearance {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            ScrollBarOptions scrollBarOptions = diagram.DefaultPane.ScrollBarOptions;

            scrollBarOptions.BackColor = Color.White;
            scrollBarOptions.BarColor = Color.Blue;
            scrollBarOptions.BorderColor = Color.Navy;
            scrollBarOptions.BarThickness = 15;
            scrollBarOptions.XAxisScrollBarAlignment = ScrollBarAlignment.Far;
            scrollBarOptions.XAxisScrollBarVisible = true;
        }
    }
}