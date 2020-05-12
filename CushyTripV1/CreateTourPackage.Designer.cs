namespace CushyTripV1
{
    partial class CreateTourPackage
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
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.rbRegular = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbJoiner = new MaterialSkin.Controls.MaterialRadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Sofia Pro ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(16, 387);
            this.numPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(236, 32);
            this.numPrice.TabIndex = 27;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.rbRegular.Checked = true;
            this.rbRegular.Depth = 0;
            this.rbRegular.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbRegular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbRegular.Location = new System.Drawing.Point(1118, 164);
            this.rbRegular.Margin = new System.Windows.Forms.Padding(0);
            this.rbRegular.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRegular.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Padding = new System.Windows.Forms.Padding(10);
            this.rbRegular.Ripple = true;
            this.rbRegular.Size = new System.Drawing.Size(133, 30);
            this.rbRegular.TabIndex = 25;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "RegularPackage.";
            this.rbRegular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRegular.UseVisualStyleBackColor = false;
            this.rbRegular.CheckedChanged += new System.EventHandler(this.rbRegular_CheckedChanged);
            // 
            // rbJoiner
            // 
            this.rbJoiner.AutoSize = true;
            this.rbJoiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.rbJoiner.Depth = 0;
            this.rbJoiner.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbJoiner.ForeColor = System.Drawing.Color.White;
            this.rbJoiner.Location = new System.Drawing.Point(1118, 114);
            this.rbJoiner.Margin = new System.Windows.Forms.Padding(0);
            this.rbJoiner.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbJoiner.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbJoiner.Name = "rbJoiner";
            this.rbJoiner.Padding = new System.Windows.Forms.Padding(10);
            this.rbJoiner.Ripple = true;
            this.rbJoiner.Size = new System.Drawing.Size(132, 30);
            this.rbJoiner.TabIndex = 24;
            this.rbJoiner.Text = "Joiner Package..";
            this.rbJoiner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJoiner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbJoiner.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1118, 738);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Sofia Pro ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(13, 86);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(951, 44);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "Name of Tour Package";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(184)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sofia Pro ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(13, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Sofia Pro ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(13, 137);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(951, 225);
            this.txtDetails.TabIndex = 20;
            this.txtDetails.Text = "Details";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(951, 285);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 365);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Price";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(1033, 35);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(245, 36);
            this.bunifuDatepicker1.TabIndex = 29;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 3, 3, 19, 42, 41, 982);
            // 
            // CreateTourPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.rbRegular);
            this.Controls.Add(this.rbJoiner);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CreateTourPackage";
            this.Text = "CreateTourPackage";
            this.Load += new System.EventHandler(this.CreateTourPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPrice;
        private MaterialSkin.Controls.MaterialRadioButton rbRegular;
        private MaterialSkin.Controls.MaterialRadioButton rbJoiner;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
    }
}