namespace Audit
{
    partial class Main
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
            this.PersonsGrid = new System.Windows.Forms.DataGridView();
            this.AddPerson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditPerson = new System.Windows.Forms.Button();
            this.FirePerson = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MoneyGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddPlata = new System.Windows.Forms.Button();
            this.Grid_Explore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Explore)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonsGrid
            // 
            this.PersonsGrid.AllowUserToAddRows = false;
            this.PersonsGrid.AllowUserToDeleteRows = false;
            this.PersonsGrid.AllowUserToResizeColumns = false;
            this.PersonsGrid.AllowUserToResizeRows = false;
            this.PersonsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PersonsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsGrid.EnableHeadersVisualStyles = false;
            this.PersonsGrid.Location = new System.Drawing.Point(12, 12);
            this.PersonsGrid.MultiSelect = false;
            this.PersonsGrid.Name = "PersonsGrid";
            this.PersonsGrid.ReadOnly = true;
            this.PersonsGrid.RowHeadersWidth = 51;
            this.PersonsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PersonsGrid.RowTemplate.Height = 29;
            this.PersonsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonsGrid.Size = new System.Drawing.Size(776, 277);
            this.PersonsGrid.TabIndex = 0;
            this.PersonsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonsGrid_CellClick);
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(6, 26);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(238, 29);
            this.AddPerson.TabIndex = 1;
            this.AddPerson.Text = "Добавить сотрудника";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditPerson);
            this.groupBox1.Controls.Add(this.FirePerson);
            this.groupBox1.Controls.Add(this.AddPerson);
            this.groupBox1.Location = new System.Drawing.Point(794, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // EditPerson
            // 
            this.EditPerson.Location = new System.Drawing.Point(6, 61);
            this.EditPerson.Name = "EditPerson";
            this.EditPerson.Size = new System.Drawing.Size(238, 29);
            this.EditPerson.TabIndex = 3;
            this.EditPerson.Text = "Изменить данные";
            this.EditPerson.UseVisualStyleBackColor = true;
            this.EditPerson.Click += new System.EventHandler(this.EditPerson_Click);
            // 
            // FirePerson
            // 
            this.FirePerson.Location = new System.Drawing.Point(6, 96);
            this.FirePerson.Name = "FirePerson";
            this.FirePerson.Size = new System.Drawing.Size(238, 29);
            this.FirePerson.TabIndex = 2;
            this.FirePerson.Text = "Уволить сотрудника";
            this.FirePerson.UseVisualStyleBackColor = true;
            this.FirePerson.Click += new System.EventHandler(this.FirePerson_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MoneyGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1365, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заработная плата";
            // 
            // MoneyGrid
            // 
            this.MoneyGrid.AllowUserToAddRows = false;
            this.MoneyGrid.AllowUserToDeleteRows = false;
            this.MoneyGrid.AllowUserToResizeColumns = false;
            this.MoneyGrid.AllowUserToResizeRows = false;
            this.MoneyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoneyGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MoneyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoneyGrid.Location = new System.Drawing.Point(6, 26);
            this.MoneyGrid.MultiSelect = false;
            this.MoneyGrid.Name = "MoneyGrid";
            this.MoneyGrid.ReadOnly = true;
            this.MoneyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.MoneyGrid.RowTemplate.Height = 29;
            this.MoneyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MoneyGrid.Size = new System.Drawing.Size(770, 230);
            this.MoneyGrid.TabIndex = 0;
            this.MoneyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoneyGrid_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddPlata);
            this.groupBox3.Location = new System.Drawing.Point(800, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заработная плата";
            // 
            // AddPlata
            // 
            this.AddPlata.Location = new System.Drawing.Point(6, 26);
            this.AddPlata.Name = "AddPlata";
            this.AddPlata.Size = new System.Drawing.Size(238, 29);
            this.AddPlata.TabIndex = 1;
            this.AddPlata.Text = "Добавить день";
            this.AddPlata.UseVisualStyleBackColor = true;
            this.AddPlata.Click += new System.EventHandler(this.AddPlata_Click);
            // 
            // Grid_Explore
            // 
            this.Grid_Explore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Explore.Location = new System.Drawing.Point(800, 321);
            this.Grid_Explore.Name = "Grid_Explore";
            this.Grid_Explore.RowHeadersWidth = 51;
            this.Grid_Explore.RowTemplate.Height = 29;
            this.Grid_Explore.Size = new System.Drawing.Size(571, 230);
            this.Grid_Explore.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 569);
            this.Controls.Add(this.Grid_Explore);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PersonsGrid);
            this.Name = "Main";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Main_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoneyGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Explore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView PersonsGrid;
        private Button AddPerson;
        private GroupBox groupBox1;
        private Button FirePerson;
        private GroupBox groupBox2;
        private Button EditPerson;
        private DataGridView MoneyGrid;
        private GroupBox groupBox3;
        private Button AddPlata;
        private DataGridView Grid_Explore;
    }
}