namespace BlaCar
{
    partial class frmAracKaydet
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iTalk_ThemeContainer1 = new iTalk.iTalk_ThemeContainer();
            this.btnKaydet = new Ambiance.Ambiance_Button_2();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.cmbModel = new Ambiance.Ambiance_ComboBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.iTalk_ControlBox1 = new iTalk.iTalk_ControlBox();
            this.cmbMarka = new Ambiance.Ambiance_ComboBox();
            this.iTalk_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_ThemeContainer1
            // 
            this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer1.Controls.Add(this.btnKaydet);
            this.iTalk_ThemeContainer1.Controls.Add(this.ambiance_Label2);
            this.iTalk_ThemeContainer1.Controls.Add(this.cmbModel);
            this.iTalk_ThemeContainer1.Controls.Add(this.ambiance_Label1);
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_ControlBox1);
            this.iTalk_ThemeContainer1.Controls.Add(this.cmbMarka);
            this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer1.Sizable = true;
            this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(372, 227);
            this.iTalk_ThemeContainer1.SmartBounds = false;
            this.iTalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.iTalk_ThemeContainer1.TabIndex = 0;
            this.iTalk_ThemeContainer1.Text = "Araç Kaydet";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Image = null;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(97, 151);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(177, 30);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(24, 98);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(59, 20);
            this.ambiance_Label2.TabIndex = 5;
            this.ambiance_Label2.Text = "Model :";
            // 
            // cmbModel
            // 
            this.cmbModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModel.DropDownHeight = 100;
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbModel.IntegralHeight = false;
            this.cmbModel.ItemHeight = 20;
            this.cmbModel.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbModel.Location = new System.Drawing.Point(154, 95);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(173, 26);
            this.cmbModel.StartIndex = 0;
            this.cmbModel.TabIndex = 4;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(24, 55);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(57, 20);
            this.ambiance_Label1.TabIndex = 3;
            this.ambiance_Label1.Text = "Marka :";
            // 
            // iTalk_ControlBox1
            // 
            this.iTalk_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox1.Location = new System.Drawing.Point(291, -1);
            this.iTalk_ControlBox1.Name = "iTalk_ControlBox1";
            this.iTalk_ControlBox1.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox1.TabIndex = 2;
            this.iTalk_ControlBox1.Text = "iTalk_ControlBox1";
            // 
            // cmbMarka
            // 
            this.cmbMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbMarka.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMarka.DropDownHeight = 100;
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMarka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbMarka.IntegralHeight = false;
            this.cmbMarka.ItemHeight = 20;
            this.cmbMarka.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbMarka.Location = new System.Drawing.Point(154, 52);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(173, 26);
            this.cmbMarka.StartIndex = 0;
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // frmAracKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 227);
            this.Controls.Add(this.iTalk_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "frmAracKaydet";
            this.Text = "Araç Kaydet";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.iTalk_ThemeContainer1.ResumeLayout(false);
            this.iTalk_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_ThemeContainer iTalk_ThemeContainer1;
        private Ambiance.Ambiance_ComboBox cmbMarka;
        private iTalk.iTalk_ControlBox iTalk_ControlBox1;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_ComboBox cmbModel;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Button_2 btnKaydet;
    }
}