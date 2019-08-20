namespace Theatre_Booking_Brook_Harkiran
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.nudSeat = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbSeatOutput = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnWho = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(182, 23);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(41, 20);
            this.lblRow.TabIndex = 3;
            this.lblRow.Text = "Row";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(275, 23);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(56, 20);
            this.lblSeat.TabIndex = 5;
            this.lblSeat.Text = "Seat #";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(135, 102);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(129, 46);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Purchase Seat";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(176, 57);
            this.nudRow.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRow.Name = "nudRow";
            this.nudRow.ReadOnly = true;
            this.nudRow.Size = new System.Drawing.Size(76, 26);
            this.nudRow.TabIndex = 7;
            this.nudRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSeat
            // 
            this.nudSeat.Location = new System.Drawing.Point(279, 57);
            this.nudSeat.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudSeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeat.Name = "nudSeat";
            this.nudSeat.ReadOnly = true;
            this.nudSeat.Size = new System.Drawing.Size(64, 26);
            this.nudSeat.TabIndex = 8;
            this.nudSeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(218, 169);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(28, 172);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Price (HST)";
            // 
            // lbSeatOutput
            // 
            this.lbSeatOutput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatOutput.FormattingEnabled = true;
            this.lbSeatOutput.ItemHeight = 23;
            this.lbSeatOutput.Location = new System.Drawing.Point(83, 350);
            this.lbSeatOutput.Name = "lbSeatOutput";
            this.lbSeatOutput.Size = new System.Drawing.Size(260, 142);
            this.lbSeatOutput.TabIndex = 11;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(23, 209);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(119, 56);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(74, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 56);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel Seat";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnWho
            // 
            this.btnWho.Location = new System.Drawing.Point(159, 209);
            this.btnWho.Name = "btnWho";
            this.btnWho.Size = new System.Drawing.Size(119, 56);
            this.btnWho.TabIndex = 14;
            this.btnWho.Text = "Who";
            this.btnWho.UseVisualStyleBackColor = true;
            this.btnWho.Click += new System.EventHandler(this.btnWho_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(297, 209);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(119, 56);
            this.btnWhere.TabIndex = 15;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(224, 283);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(119, 56);
            this.btnTotal.TabIndex = 16;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 504);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnWho);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lbSeatOutput);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.nudSeat);
            this.Controls.Add(this.nudRow);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Ticket Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.NumericUpDown nudSeat;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbSeatOutput;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnWho;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnTotal;
    }
}

