using Telerik.WinControls.UI;

namespace StatusSdgByLab
{
    partial class StatusSdgByLabcls
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.ddlLabs = new Telerik.WinControls.UI.RadDropDownList();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPie = new System.Windows.Forms.RadioButton();
            this.rbBar = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlLabs
            // 
            this.ddlLabs.Location = new System.Drawing.Point(509, 62);
            this.ddlLabs.Name = "ddlLabs";
            this.ddlLabs.Size = new System.Drawing.Size(125, 20);
            this.ddlLabs.TabIndex = 1;
            this.ddlLabs.Text = "ddlLabs";
            this.ddlLabs.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlLabs_SelectedIndexChanged_1);
            // 
            // radChartView1
            // 
            cartesianArea1.ShowGrid = true;
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Location = new System.Drawing.Point(23, 14);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.SelectionMode = Telerik.WinControls.UI.ChartSelectionMode.MultipleDataPoints;
            this.radChartView1.ShowLegend = true;
            this.radChartView1.ShowPanZoom = true;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.ShowTrackBall = true;
            this.radChartView1.Size = new System.Drawing.Size(480, 320);
            this.radChartView1.TabIndex = 2;
            this.radChartView1.Text = "radChartView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // rbPie
            // 
            this.rbPie.AutoSize = true;
            this.rbPie.Location = new System.Drawing.Point(529, 232);
            this.rbPie.Name = "rbPie";
            this.rbPie.Size = new System.Drawing.Size(40, 17);
            this.rbPie.TabIndex = 4;
            this.rbPie.TabStop = true;
            this.rbPie.Text = "Pie";
            this.rbPie.UseVisualStyleBackColor = true;
            // 
            // rbBar
            // 
            this.rbBar.AutoSize = true;
            this.rbBar.Location = new System.Drawing.Point(529, 255);
            this.rbBar.Name = "rbBar";
            this.rbBar.Size = new System.Drawing.Size(41, 17);
            this.rbBar.TabIndex = 5;
            this.rbBar.TabStop = true;
            this.rbBar.Text = "Bar";
            this.rbBar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StatusSdgByLabcls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbBar);
            this.Controls.Add(this.rbPie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radChartView1);
            this.Controls.Add(this.ddlLabs);
            this.Name = "StatusSdgByLabcls";
            this.Size = new System.Drawing.Size(641, 346);
            ((System.ComponentModel.ISupportInitialize)(this.ddlLabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlLabs;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPie;
        private System.Windows.Forms.RadioButton rbBar;
        private System.Windows.Forms.Button button1;


    }
}
