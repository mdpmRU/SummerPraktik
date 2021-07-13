
namespace WarehouseProject
{
    partial class WarehouseF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVWarehouse = new System.Windows.Forms.DataGridView();
            this.OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBD = new System.Windows.Forms.Button();
            this.Btn_Ed = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_oc = new System.Windows.Forms.TextBox();
            this.btnP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVWarehouse
            // 
            this.dGVWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderCode,
            this.ItemCode,
            this.FirstName,
            this.LastName,
            this.MiddleName,
            this.Address,
            this.Quantity,
            this.Email,
            this.Status,
            this.Order_date});
            this.dGVWarehouse.Location = new System.Drawing.Point(9, 188);
            this.dGVWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVWarehouse.Name = "dGVWarehouse";
            this.dGVWarehouse.RowHeadersWidth = 51;
            this.dGVWarehouse.RowTemplate.Height = 24;
            this.dGVWarehouse.Size = new System.Drawing.Size(1250, 234);
            this.dGVWarehouse.TabIndex = 0;
            // 
            // OrderCode
            // 
            this.OrderCode.HeaderText = "Код товара";
            this.OrderCode.MinimumWidth = 6;
            this.OrderCode.Name = "OrderCode";
            this.OrderCode.Width = 125;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Код пункта";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.MinimumWidth = 6;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Order_date
            // 
            this.Order_date.HeaderText = "Дата заказа";
            this.Order_date.MinimumWidth = 6;
            this.Order_date.Name = "Order_date";
            this.Order_date.Width = 125;
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(9, 135);
            this.btnBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(118, 41);
            this.btnBD.TabIndex = 1;
            this.btnBD.Text = "Вывод БД заказов";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // Btn_Ed
            // 
            this.Btn_Ed.Location = new System.Drawing.Point(1156, 50);
            this.Btn_Ed.Name = "Btn_Ed";
            this.Btn_Ed.Size = new System.Drawing.Size(103, 39);
            this.Btn_Ed.TabIndex = 3;
            this.Btn_Ed.Text = "Завершить заказ";
            this.Btn_Ed.UseVisualStyleBackColor = true;
            this.Btn_Ed.Click += new System.EventHandler(this.Btn_Ed_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1154, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Введите OrderCode ";
            // 
            // tb_oc
            // 
            this.tb_oc.Location = new System.Drawing.Point(1156, 24);
            this.tb_oc.Name = "tb_oc";
            this.tb_oc.Size = new System.Drawing.Size(103, 20);
            this.tb_oc.TabIndex = 22;
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(140, 146);
            this.btnP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(56, 19);
            this.btnP.TabIndex = 24;
            this.btnP.Text = "Print";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // WarehouseF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 432);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_oc);
            this.Controls.Add(this.Btn_Ed);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.dGVWarehouse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WarehouseF";
            this.Text = "Приложение для работника склада";
            ((System.ComponentModel.ISupportInitialize)(this.dGVWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVWarehouse;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_date;
        private System.Windows.Forms.Button Btn_Ed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_oc;
        private System.Windows.Forms.Button btnP;
    }
}

