namespace LR3_task
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
            listBoxItems = new ListBox();
            add = new Button();
            edit = new Button();
            delete = new Button();
            search = new Button();
            textBoxInput = new TextBox();
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(25, 65);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(150, 104);
            listBoxItems.TabIndex = 0;
            // 
            // add
            // 
            add.Location = new Point(25, 398);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.Location = new Point(135, 398);
            edit.Name = "edit";
            edit.Size = new Size(124, 29);
            edit.TabIndex = 2;
            edit.Text = "Редактировать";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(274, 398);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 3;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.Location = new Point(384, 398);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 4;
            search.Text = "Поиск";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(25, 41);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(150, 27);
            textBoxInput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInput);
            Controls.Add(search);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(listBoxItems);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxItems;
        private Button add;
        private Button edit;
        private Button delete;
        private Button search;
        private TextBox textBoxInput;
    }
}
