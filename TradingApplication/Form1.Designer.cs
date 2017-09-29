namespace TradingApplication
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsgroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientnametextBox = new System.Windows.Forms.TextBox();
            this.itemsnamecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unitpricetextBox = new System.Windows.Forms.TextBox();
            this.addtochartbutton = new System.Windows.Forms.Button();
            this.neworderbutton = new System.Windows.Forms.Button();
            this.printorderbutton = new System.Windows.Forms.Button();
            this.printpreviewbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.totalamounttextBox = new System.Windows.Forms.TextBox();
            this.saletaxtextBox = new System.Windows.Forms.TextBox();
            this.totaltopaytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itemsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(705, 434);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(3, 1);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(698, 66);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hassan Malik Trading Ltd.Bahawalnagar";
            // 
            // itemsgroupBox
            // 
            this.itemsgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsgroupBox.Controls.Add(this.addtochartbutton);
            this.itemsgroupBox.Controls.Add(this.unitpricetextBox);
            this.itemsgroupBox.Controls.Add(this.quantitytextBox);
            this.itemsgroupBox.Controls.Add(this.label5);
            this.itemsgroupBox.Controls.Add(this.label4);
            this.itemsgroupBox.Controls.Add(this.itemsnamecomboBox);
            this.itemsgroupBox.Controls.Add(this.clientnametextBox);
            this.itemsgroupBox.Controls.Add(this.label3);
            this.itemsgroupBox.Controls.Add(this.label2);
            this.itemsgroupBox.Enabled = false;
            this.itemsgroupBox.Location = new System.Drawing.Point(2, 68);
            this.itemsgroupBox.Name = "itemsgroupBox";
            this.itemsgroupBox.Size = new System.Drawing.Size(532, 100);
            this.itemsgroupBox.TabIndex = 2;
            this.itemsgroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Name:";
            // 
            // clientnametextBox
            // 
            this.clientnametextBox.Location = new System.Drawing.Point(91, 17);
            this.clientnametextBox.Name = "clientnametextBox";
            this.clientnametextBox.Size = new System.Drawing.Size(224, 20);
            this.clientnametextBox.TabIndex = 0;
            // 
            // itemsnamecomboBox
            // 
            this.itemsnamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsnamecomboBox.FormattingEnabled = true;
            this.itemsnamecomboBox.Items.AddRange(new object[] {
            "php",
            "java",
            "css",
            "c#",
            "python",
            "wordpress",
            "c++",
            "c",
            "datastructure"});
            this.itemsnamecomboBox.Location = new System.Drawing.Point(91, 73);
            this.itemsnamecomboBox.Name = "itemsnamecomboBox";
            this.itemsnamecomboBox.Size = new System.Drawing.Size(121, 21);
            this.itemsnamecomboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Items Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(245, 74);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(70, 20);
            this.quantitytextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Unit Price:";
            // 
            // unitpricetextBox
            // 
            this.unitpricetextBox.Location = new System.Drawing.Point(345, 74);
            this.unitpricetextBox.Name = "unitpricetextBox";
            this.unitpricetextBox.Size = new System.Drawing.Size(70, 20);
            this.unitpricetextBox.TabIndex = 3;
            // 
            // addtochartbutton
            // 
            this.addtochartbutton.Location = new System.Drawing.Point(445, 37);
            this.addtochartbutton.Name = "addtochartbutton";
            this.addtochartbutton.Size = new System.Drawing.Size(75, 57);
            this.addtochartbutton.TabIndex = 4;
            this.addtochartbutton.Text = "Add to Chart";
            this.addtochartbutton.UseVisualStyleBackColor = true;
            // 
            // neworderbutton
            // 
            this.neworderbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.neworderbutton.Location = new System.Drawing.Point(557, 78);
            this.neworderbutton.Name = "neworderbutton";
            this.neworderbutton.Size = new System.Drawing.Size(136, 23);
            this.neworderbutton.TabIndex = 5;
            this.neworderbutton.Text = "New Order";
            this.neworderbutton.UseVisualStyleBackColor = true;
            this.neworderbutton.Click += new System.EventHandler(this.neworderbutton_Click);
            // 
            // printorderbutton
            // 
            this.printorderbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printorderbutton.Enabled = false;
            this.printorderbutton.Location = new System.Drawing.Point(557, 111);
            this.printorderbutton.Name = "printorderbutton";
            this.printorderbutton.Size = new System.Drawing.Size(136, 23);
            this.printorderbutton.TabIndex = 6;
            this.printorderbutton.Text = "Print Order";
            this.printorderbutton.UseVisualStyleBackColor = true;
            // 
            // printpreviewbutton
            // 
            this.printpreviewbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printpreviewbutton.Enabled = false;
            this.printpreviewbutton.Location = new System.Drawing.Point(557, 145);
            this.printpreviewbutton.Name = "printpreviewbutton";
            this.printpreviewbutton.Size = new System.Drawing.Size(136, 23);
            this.printpreviewbutton.TabIndex = 7;
            this.printpreviewbutton.Text = "Print Preview";
            this.printpreviewbutton.UseVisualStyleBackColor = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelbutton.Enabled = false;
            this.cancelbutton.Location = new System.Drawing.Point(2, 357);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(141, 23);
            this.cancelbutton.TabIndex = 8;
            this.cancelbutton.Text = "Cancel Order";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(690, 183);
            this.dataGridView1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Amount:";
            // 
            // totalamounttextBox
            // 
            this.totalamounttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalamounttextBox.Location = new System.Drawing.Point(595, 357);
            this.totalamounttextBox.Name = "totalamounttextBox";
            this.totalamounttextBox.ReadOnly = true;
            this.totalamounttextBox.Size = new System.Drawing.Size(97, 20);
            this.totalamounttextBox.TabIndex = 7;
            this.totalamounttextBox.Text = "0";
            this.totalamounttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saletaxtextBox
            // 
            this.saletaxtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saletaxtextBox.Location = new System.Drawing.Point(595, 381);
            this.saletaxtextBox.Name = "saletaxtextBox";
            this.saletaxtextBox.ReadOnly = true;
            this.saletaxtextBox.Size = new System.Drawing.Size(97, 20);
            this.saletaxtextBox.TabIndex = 7;
            this.saletaxtextBox.Text = "0";
            this.saletaxtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totaltopaytextBox
            // 
            this.totaltopaytextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totaltopaytextBox.Location = new System.Drawing.Point(595, 407);
            this.totaltopaytextBox.Name = "totaltopaytextBox";
            this.totaltopaytextBox.ReadOnly = true;
            this.totaltopaytextBox.Size = new System.Drawing.Size(97, 20);
            this.totaltopaytextBox.TabIndex = 7;
            this.totaltopaytextBox.Text = "0";
            this.totaltopaytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sales Tax:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total to Pay:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 434);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totaltopaytextBox);
            this.Controls.Add(this.saletaxtextBox);
            this.Controls.Add(this.totalamounttextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.printpreviewbutton);
            this.Controls.Add(this.printorderbutton);
            this.Controls.Add(this.neworderbutton);
            this.Controls.Add(this.itemsgroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.itemsgroupBox.ResumeLayout(false);
            this.itemsgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox itemsgroupBox;
        private System.Windows.Forms.Button addtochartbutton;
        private System.Windows.Forms.TextBox unitpricetextBox;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemsnamecomboBox;
        private System.Windows.Forms.TextBox clientnametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button neworderbutton;
        private System.Windows.Forms.Button printorderbutton;
        private System.Windows.Forms.Button printpreviewbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalamounttextBox;
        private System.Windows.Forms.TextBox saletaxtextBox;
        private System.Windows.Forms.TextBox totaltopaytextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

