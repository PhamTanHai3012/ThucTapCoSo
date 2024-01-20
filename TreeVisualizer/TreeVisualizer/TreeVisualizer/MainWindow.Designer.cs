
using System.Windows.Forms;

namespace TreeVisualizer
{
    partial class MainWindow
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Remove = new System.Windows.Forms.TextBox();
            this.txt_Insert = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBox_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox_Control, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1308, 736);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1302, 630);
            this.panel.TabIndex = 1;
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.Controls.Add(this.btn_Search);
            this.groupBox_Control.Controls.Add(this.txt_Search);
            this.groupBox_Control.Controls.Add(this.btn_Remove);
            this.groupBox_Control.Controls.Add(this.btn_Insert);
            this.groupBox_Control.Controls.Add(this.txt_Remove);
            this.groupBox_Control.Controls.Add(this.txt_Insert);
            this.groupBox_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Control.Location = new System.Drawing.Point(3, 639);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Size = new System.Drawing.Size(1302, 94);
            this.groupBox_Control.TabIndex = 2;
            this.groupBox_Control.TabStop = false;
            this.groupBox_Control.Text = "Chức năng";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1146, 44);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(150, 30);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "TÌM KIẾM";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(890, 44);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(250, 30);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(703, 44);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(150, 30);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "XÓA";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(265, 44);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(150, 30);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "CHÈN";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Remove
            // 
            this.txt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remove.Location = new System.Drawing.Point(447, 44);
            this.txt_Remove.Name = "txt_Remove";
            this.txt_Remove.Size = new System.Drawing.Size(250, 30);
            this.txt_Remove.TabIndex = 1;
            this.txt_Remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Insert
            // 
            this.txt_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Insert.Location = new System.Drawing.Point(9, 44);
            this.txt_Insert.Name = "txt_Insert";
            this.txt_Insert.Size = new System.Drawing.Size(250, 30);
            this.txt_Insert.TabIndex = 0;
            this.txt_Insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 736);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "AVL Tree";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txt_Remove;
        private System.Windows.Forms.TextBox txt_Insert;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel;

    }
}