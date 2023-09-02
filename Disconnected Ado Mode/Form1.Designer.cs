namespace Disconnected_Ado_Mode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_topic = new DataGridView();
            txt_tname = new TextBox();
            label1 = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_topic).BeginInit();
            SuspendLayout();
            // 
            // dgv_topic
            // 
            dgv_topic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_topic.Location = new Point(-4, 251);
            dgv_topic.Name = "dgv_topic";
            dgv_topic.RowHeadersWidth = 51;
            dgv_topic.RowTemplate.Height = 29;
            dgv_topic.Size = new Size(802, 200);
            dgv_topic.TabIndex = 0;
            dgv_topic.RowHeaderMouseDoubleClick += dgv_topic_RowHeaderMouseDoubleClick;
            // 
            // txt_tname
            // 
            txt_tname.Location = new Point(290, 76);
            txt_tname.Name = "txt_tname";
            txt_tname.Size = new Size(193, 27);
            txt_tname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 83);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "Topic Name";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(132, 160);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 3;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(326, 160);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 29);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(511, 160);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label1);
            Controls.Add(txt_tname);
            Controls.Add(dgv_topic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_topic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_topic;
        private TextBox txt_tname;
        private Label label1;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
    }
}