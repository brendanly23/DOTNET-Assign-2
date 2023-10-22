namespace DOTNET_Assignment_2
{
    partial class AdminShowAllClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.subjectManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectManagementDataSet = new DOTNET_Assignment_2.SubjectManagementDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.subjectManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(310, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Subjects";
            // 
            // subjectManagementDataSetBindingSource
            // 
            this.subjectManagementDataSetBindingSource.DataSource = this.subjectManagementDataSet;
            this.subjectManagementDataSetBindingSource.Position = 0;
            this.subjectManagementDataSetBindingSource.CurrentChanged += new System.EventHandler(this.subjectManagementDataSetBindingSource_CurrentChanged);
            // 
            // subjectManagementDataSet
            // 
            this.subjectManagementDataSet.DataSetName = "SubjectManagementDataSet";
            this.subjectManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminShowAllSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "AdminShowAllSubjects";
            this.Text = "AdminShowAllSubjects";
            this.Load += new System.EventHandler(this.AdminShowAllSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource subjectManagementDataSetBindingSource;
        private SubjectManagementDataSet subjectManagementDataSet;
    }
}