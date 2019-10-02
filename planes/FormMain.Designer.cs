namespace planes
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timermain = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFirm = new System.Windows.Forms.ComboBox();
            this.radioButtonFirm = new System.Windows.Forms.RadioButton();
            this.radioButtonOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonFuel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPlanes = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 184);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // timermain
            // 
            this.timermain.Interval = 1000;
            this.timermain.Tick += new System.EventHandler(this.timermain_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(17, 25);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(108, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Время остановлено";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(20, 53);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(20, 82);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 320);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(425, 150);
            this.textBoxLog.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список Рейсов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Отчет";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFirm);
            this.groupBox1.Controls.Add(this.radioButtonFirm);
            this.groupBox1.Controls.Add(this.radioButtonOrder);
            this.groupBox1.Controls.Add(this.radioButtonFuel);
            this.groupBox1.Location = new System.Drawing.Point(456, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диспетчер";
            // 
            // comboBoxFirm
            // 
            this.comboBoxFirm.FormattingEnabled = true;
            this.comboBoxFirm.Location = new System.Drawing.Point(31, 88);
            this.comboBoxFirm.Name = "comboBoxFirm";
            this.comboBoxFirm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFirm.TabIndex = 2;
            this.comboBoxFirm.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirm_SelectedIndexChanged);
            // 
            // radioButtonFirm
            // 
            this.radioButtonFirm.AutoSize = true;
            this.radioButtonFirm.Location = new System.Drawing.Point(11, 65);
            this.radioButtonFirm.Name = "radioButtonFirm";
            this.radioButtonFirm.Size = new System.Drawing.Size(62, 17);
            this.radioButtonFirm.TabIndex = 1;
            this.radioButtonFirm.Text = "Фирма";
            this.radioButtonFirm.UseVisualStyleBackColor = true;
            this.radioButtonFirm.CheckedChanged += new System.EventHandler(this.radioButtonFirm_CheckedChanged);
            // 
            // radioButtonOrder
            // 
            this.radioButtonOrder.AutoSize = true;
            this.radioButtonOrder.Location = new System.Drawing.Point(11, 42);
            this.radioButtonOrder.Name = "radioButtonOrder";
            this.radioButtonOrder.Size = new System.Drawing.Size(68, 17);
            this.radioButtonOrder.TabIndex = 1;
            this.radioButtonOrder.Text = "Очереди";
            this.radioButtonOrder.UseVisualStyleBackColor = true;
            this.radioButtonOrder.CheckedChanged += new System.EventHandler(this.radioButtonOrder_CheckedChanged);
            // 
            // radioButtonFuel
            // 
            this.radioButtonFuel.AutoSize = true;
            this.radioButtonFuel.Checked = true;
            this.radioButtonFuel.Location = new System.Drawing.Point(11, 19);
            this.radioButtonFuel.Name = "radioButtonFuel";
            this.radioButtonFuel.Size = new System.Drawing.Size(82, 17);
            this.radioButtonFuel.TabIndex = 0;
            this.radioButtonFuel.TabStop = true;
            this.radioButtonFuel.Text = "По топливу";
            this.radioButtonFuel.UseVisualStyleBackColor = true;
            this.radioButtonFuel.CheckedChanged += new System.EventHandler(this.radioButtonFuel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTime);
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Location = new System.Drawing.Point(456, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 126);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Время";
            // 
            // comboBoxPlanes
            // 
            this.comboBoxPlanes.FormattingEnabled = true;
            this.comboBoxPlanes.Location = new System.Drawing.Point(12, 43);
            this.comboBoxPlanes.Name = "comboBoxPlanes";
            this.comboBoxPlanes.Size = new System.Drawing.Size(342, 21);
            this.comboBoxPlanes.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(362, 43);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Добавить Самолет:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 489);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxPlanes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "АвтоДиспетчер";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timermain;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFirm;
        private System.Windows.Forms.RadioButton radioButtonFirm;
        private System.Windows.Forms.RadioButton radioButtonOrder;
        private System.Windows.Forms.RadioButton radioButtonFuel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPlanes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
    }
}

