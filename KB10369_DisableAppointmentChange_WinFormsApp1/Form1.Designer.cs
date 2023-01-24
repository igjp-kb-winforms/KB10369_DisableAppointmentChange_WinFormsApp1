namespace KB10369_DisableAppointmentChange_WinFormsApp1;

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
            this.components = new System.ComponentModel.Container();
            this.ultraTimelineView1 = new Infragistics.Win.UltraWinSchedule.UltraTimelineView();
            this.ultraCalendarInfo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTimelineView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraTimelineView1
            // 
            this.ultraTimelineView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTimelineView1.Location = new System.Drawing.Point(0, 0);
            this.ultraTimelineView1.Name = "ultraTimelineView1";
            this.ultraTimelineView1.Size = new System.Drawing.Size(800, 450);
            this.ultraTimelineView1.TabIndex = 0;
            // 
            // ultraCalendarInfo1
            // 
            this.ultraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = this;
            this.ultraCalendarInfo1.DataBindingsForOwners.BindingContextControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultraTimelineView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTimelineView1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private Infragistics.Win.UltraWinSchedule.UltraTimelineView ultraTimelineView1;
    private Infragistics.Win.UltraWinSchedule.UltraCalendarInfo ultraCalendarInfo1;
}
