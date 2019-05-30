namespace XOutput.Forms
{
     partial class NewXOut
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewXOut));
               this.TitleBar = new System.Windows.Forms.Panel();
               this.label1 = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.MinimizeButton = new System.Windows.Forms.Button();
               this.CloseButton = new System.Windows.Forms.Button();
               this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
               this.ControllerButton1 = new System.Windows.Forms.Button();
               this.ControllerButton2 = new System.Windows.Forms.Button();
               this.ControllerButton3 = new System.Windows.Forms.Button();
               this.ControllerButton4 = new System.Windows.Forms.Button();
               this.toggleButton1 = new ToggleButton();
               this.customComboBox1 = new XOutput.CustomComboBox();
               this.customComboBox2 = new XOutput.CustomComboBox();
               this.customComboBox3 = new XOutput.CustomComboBox();
               this.customComboBox4 = new XOutput.CustomComboBox();
               this.toggleButton2 = new ToggleButton();
               this.toggleButton3 = new ToggleButton();
               this.toggleButton4 = new ToggleButton();
               this.TitleBar.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.tableLayoutPanel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // TitleBar
               // 
               this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
               this.TitleBar.Controls.Add(this.label1);
               this.TitleBar.Controls.Add(this.pictureBox1);
               this.TitleBar.Controls.Add(this.MinimizeButton);
               this.TitleBar.Controls.Add(this.CloseButton);
               this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
               this.TitleBar.Location = new System.Drawing.Point(0, 0);
               this.TitleBar.Name = "TitleBar";
               this.TitleBar.Size = new System.Drawing.Size(553, 30);
               this.TitleBar.TabIndex = 0;
               this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
               this.label1.Location = new System.Drawing.Point(36, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(51, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "XOutput";
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
               this.pictureBox1.Location = new System.Drawing.Point(0, 0);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(30, 30);
               this.pictureBox1.TabIndex = 1;
               this.pictureBox1.TabStop = false;
               // 
               // MinimizeButton
               // 
               this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.MinimizeButton.FlatAppearance.BorderSize = 0;
               this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
               this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.MinimizeButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
               this.MinimizeButton.Location = new System.Drawing.Point(453, 0);
               this.MinimizeButton.Name = "MinimizeButton";
               this.MinimizeButton.Size = new System.Drawing.Size(50, 30);
               this.MinimizeButton.TabIndex = 0;
               this.MinimizeButton.Text = "_";
               this.MinimizeButton.UseVisualStyleBackColor = true;
               this.MinimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseClick);
               // 
               // CloseButton
               // 
               this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
               this.CloseButton.FlatAppearance.BorderSize = 0;
               this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
               this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
               this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.CloseButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
               this.CloseButton.Location = new System.Drawing.Point(503, 0);
               this.CloseButton.Name = "CloseButton";
               this.CloseButton.Size = new System.Drawing.Size(50, 30);
               this.CloseButton.TabIndex = 0;
               this.CloseButton.Text = "X";
               this.CloseButton.UseVisualStyleBackColor = true;
               this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
               // 
               // tableLayoutPanel1
               // 
               this.tableLayoutPanel1.ColumnCount = 4;
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.tableLayoutPanel1.Controls.Add(this.ControllerButton1, 0, 0);
               this.tableLayoutPanel1.Controls.Add(this.ControllerButton2, 1, 0);
               this.tableLayoutPanel1.Controls.Add(this.ControllerButton3, 2, 0);
               this.tableLayoutPanel1.Controls.Add(this.ControllerButton4, 3, 0);
               this.tableLayoutPanel1.Controls.Add(this.toggleButton1, 0, 2);
               this.tableLayoutPanel1.Controls.Add(this.customComboBox1, 0, 1);
               this.tableLayoutPanel1.Controls.Add(this.customComboBox2, 1, 1);
               this.tableLayoutPanel1.Controls.Add(this.customComboBox3, 2, 1);
               this.tableLayoutPanel1.Controls.Add(this.customComboBox4, 3, 1);
               this.tableLayoutPanel1.Controls.Add(this.toggleButton2, 1, 2);
               this.tableLayoutPanel1.Controls.Add(this.toggleButton3, 2, 2);
               this.tableLayoutPanel1.Controls.Add(this.toggleButton4, 3, 2);
               this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
               this.tableLayoutPanel1.Name = "tableLayoutPanel1";
               this.tableLayoutPanel1.RowCount = 4;
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 205);
               this.tableLayoutPanel1.TabIndex = 1;
               // 
               // ControllerButton1
               // 
               this.ControllerButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.ControllerButton1.BackgroundImage = global::XOutput.Properties.Resources.controller_icon;
               this.ControllerButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
               this.ControllerButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.ControllerButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
               this.ControllerButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.ControllerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ControllerButton1.Location = new System.Drawing.Point(9, 9);
               this.ControllerButton1.Name = "ControllerButton1";
               this.ControllerButton1.Size = new System.Drawing.Size(120, 120);
               this.ControllerButton1.TabIndex = 0;
               this.ControllerButton1.UseVisualStyleBackColor = true;
               // 
               // ControllerButton2
               // 
               this.ControllerButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.ControllerButton2.BackgroundImage = global::XOutput.Properties.Resources.controller_icon;
               this.ControllerButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
               this.ControllerButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.ControllerButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
               this.ControllerButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.ControllerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ControllerButton2.Location = new System.Drawing.Point(147, 9);
               this.ControllerButton2.Name = "ControllerButton2";
               this.ControllerButton2.Size = new System.Drawing.Size(120, 120);
               this.ControllerButton2.TabIndex = 0;
               this.ControllerButton2.UseVisualStyleBackColor = true;
               // 
               // ControllerButton3
               // 
               this.ControllerButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.ControllerButton3.BackgroundImage = global::XOutput.Properties.Resources.controller_icon;
               this.ControllerButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
               this.ControllerButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.ControllerButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
               this.ControllerButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.ControllerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ControllerButton3.Location = new System.Drawing.Point(285, 9);
               this.ControllerButton3.Name = "ControllerButton3";
               this.ControllerButton3.Size = new System.Drawing.Size(120, 120);
               this.ControllerButton3.TabIndex = 0;
               this.ControllerButton3.UseVisualStyleBackColor = true;
               // 
               // ControllerButton4
               // 
               this.ControllerButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.ControllerButton4.BackgroundImage = global::XOutput.Properties.Resources.controller_icon;
               this.ControllerButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
               this.ControllerButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.ControllerButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
               this.ControllerButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.ControllerButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ControllerButton4.Location = new System.Drawing.Point(423, 9);
               this.ControllerButton4.Name = "ControllerButton4";
               this.ControllerButton4.Size = new System.Drawing.Size(120, 120);
               this.ControllerButton4.TabIndex = 0;
               this.ControllerButton4.UseVisualStyleBackColor = true;
               // 
               // toggleButton1
               // 
               this.toggleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.toggleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.toggleButton1.KnobOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.toggleButton1.Location = new System.Drawing.Point(45, 171);
               this.toggleButton1.Name = "toggleButton1";
               this.toggleButton1.Padding = new System.Windows.Forms.Padding(6);
               this.toggleButton1.Size = new System.Drawing.Size(48, 24);
               this.toggleButton1.TabIndex = 4;
               this.toggleButton1.Text = "toggleButton1";
               this.toggleButton1.UseVisualStyleBackColor = true;
               // 
               // customComboBox1
               // 
               this.customComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.customComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
               this.customComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.customComboBox1.BorderWidth = 1;
               this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.customComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.customComboBox1.FormattingEnabled = true;
               this.customComboBox1.Location = new System.Drawing.Point(8, 142);
               this.customComboBox1.Name = "customComboBox1";
               this.customComboBox1.Size = new System.Drawing.Size(121, 21);
               this.customComboBox1.TabIndex = 5;
               // 
               // customComboBox2
               // 
               this.customComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.customComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
               this.customComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.customComboBox2.BorderWidth = 1;
               this.customComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.customComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.customComboBox2.FormattingEnabled = true;
               this.customComboBox2.Location = new System.Drawing.Point(146, 142);
               this.customComboBox2.Name = "customComboBox2";
               this.customComboBox2.Size = new System.Drawing.Size(121, 21);
               this.customComboBox2.TabIndex = 5;
               // 
               // customComboBox3
               // 
               this.customComboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.customComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
               this.customComboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.customComboBox3.BorderWidth = 1;
               this.customComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.customComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.customComboBox3.FormattingEnabled = true;
               this.customComboBox3.Location = new System.Drawing.Point(284, 142);
               this.customComboBox3.Name = "customComboBox3";
               this.customComboBox3.Size = new System.Drawing.Size(121, 21);
               this.customComboBox3.TabIndex = 5;
               // 
               // customComboBox4
               // 
               this.customComboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.customComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
               this.customComboBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.customComboBox4.BorderWidth = 1;
               this.customComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.customComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.customComboBox4.FormattingEnabled = true;
               this.customComboBox4.Location = new System.Drawing.Point(423, 142);
               this.customComboBox4.Name = "customComboBox4";
               this.customComboBox4.Size = new System.Drawing.Size(121, 21);
               this.customComboBox4.TabIndex = 5;
               // 
               // toggleButton2
               // 
               this.toggleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.toggleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.toggleButton2.KnobOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.toggleButton2.Location = new System.Drawing.Point(183, 171);
               this.toggleButton2.Name = "toggleButton2";
               this.toggleButton2.Padding = new System.Windows.Forms.Padding(6);
               this.toggleButton2.Size = new System.Drawing.Size(48, 24);
               this.toggleButton2.TabIndex = 4;
               this.toggleButton2.Text = "toggleButton1";
               this.toggleButton2.UseVisualStyleBackColor = true;
               // 
               // toggleButton3
               // 
               this.toggleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.toggleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.toggleButton3.KnobOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.toggleButton3.Location = new System.Drawing.Point(321, 171);
               this.toggleButton3.Name = "toggleButton3";
               this.toggleButton3.Padding = new System.Windows.Forms.Padding(6);
               this.toggleButton3.Size = new System.Drawing.Size(48, 24);
               this.toggleButton3.TabIndex = 4;
               this.toggleButton3.Text = "toggleButton1";
               this.toggleButton3.UseVisualStyleBackColor = true;
               // 
               // toggleButton4
               // 
               this.toggleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.toggleButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.toggleButton4.KnobOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
               this.toggleButton4.Location = new System.Drawing.Point(459, 171);
               this.toggleButton4.Name = "toggleButton4";
               this.toggleButton4.Padding = new System.Windows.Forms.Padding(6);
               this.toggleButton4.Size = new System.Drawing.Size(48, 24);
               this.toggleButton4.TabIndex = 4;
               this.toggleButton4.Text = "toggleButton1";
               this.toggleButton4.UseVisualStyleBackColor = true;
               // 
               // NewXOut
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
               this.CancelButton = this.CloseButton;
               this.ClientSize = new System.Drawing.Size(553, 235);
               this.Controls.Add(this.tableLayoutPanel1);
               this.Controls.Add(this.TitleBar);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "NewXOut";
               this.Text = "NewXOut";
               this.TitleBar.ResumeLayout(false);
               this.TitleBar.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.tableLayoutPanel1.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel TitleBar;
          private System.Windows.Forms.Button MinimizeButton;
          private System.Windows.Forms.Button CloseButton;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
          private System.Windows.Forms.Button ControllerButton1;
          private System.Windows.Forms.Button ControllerButton2;
          private System.Windows.Forms.Button ControllerButton3;
          private System.Windows.Forms.Button ControllerButton4;
          private ToggleButton toggleButton1;
          private CustomComboBox customComboBox1;
          private CustomComboBox customComboBox2;
          private CustomComboBox customComboBox3;
          private CustomComboBox customComboBox4;
          private ToggleButton toggleButton2;
          private ToggleButton toggleButton3;
          private ToggleButton toggleButton4;
     }
}
