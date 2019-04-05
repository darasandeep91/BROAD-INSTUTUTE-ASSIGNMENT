namespace Test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.routeAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.routeAttributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.routeAttributesBindingSource;
            this.listBox1.DisplayMember = "long_name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 121);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "long_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Routes ";
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataSource = typeof(Test.route);
            // 
            // stopsBindingSource
            // 
            this.stopsBindingSource.DataMember = "stops";
            this.stopsBindingSource.DataSource = this.routeBindingSource;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(30, 238);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(214, 108);
            this.listBox2.TabIndex = 3;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(284, 238);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(204, 108);
            this.listBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 404);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 404);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(554, 385);
            this.listBox4.MaximumSize = new System.Drawing.Size(223, 108);
            this.listBox4.MinimumSize = new System.Drawing.Size(223, 108);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(223, 108);
            this.listBox4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "BROAD INSTITUTE ASSIGNMENT ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "List of Common Stop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "List of Routes for Each Stop ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "List of Routes For 2 Stops ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Please Select Stops:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 505);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(926, 544);
            this.MinimumSize = new System.Drawing.Size(926, 544);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "BROAD INSTITUTE ASSIGNMENT ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routeAttributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource routeAttributesBindingSource;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private System.Windows.Forms.BindingSource stopsBindingSource;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

