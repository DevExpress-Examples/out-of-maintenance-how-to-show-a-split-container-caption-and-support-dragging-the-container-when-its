namespace DXSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.customDockManager1 = new DXSample.CustomDockManager(this.components);
            this.panelContainer1 = new DXSample.CustomDockPanel();
            this.customDockPanel1 = new DXSample.CustomDockPanel();
            this.customDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.customDockPanel2 = new DXSample.CustomDockPanel();
            this.customDockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customDockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.customDockPanel1.SuspendLayout();
            this.customDockPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customDockManager1
            // 
            this.customDockManager1.Form = this;
            this.customDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.customDockManager1.ShowSplitContainerCaptionAlways = true;
            this.customDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.customDockPanel1);
            this.panelContainer1.Controls.Add(this.customDockPanel2);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.panelContainer1.FloatLocation = new System.Drawing.Point(128, 268);
            this.panelContainer1.FloatSize = new System.Drawing.Size(369, 302);
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("95525a26-5a04-4cf1-aa44-1b00391bda1e");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.Size = new System.Drawing.Size(369, 302);
            this.panelContainer1.Text = "SplitContainerCaption";
            // 
            // customDockPanel1
            // 
            this.customDockPanel1.Controls.Add(this.customDockPanel1_Container);
            this.customDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.customDockPanel1.FloatSize = new System.Drawing.Size(194, 278);
            this.customDockPanel1.FloatVertical = true;
            this.customDockPanel1.ID = new System.Guid("769afdb8-d63d-472f-b9f4-5af902ee7681");
            this.customDockPanel1.Location = new System.Drawing.Point(1, 23);
            this.customDockPanel1.Name = "customDockPanel1";
            this.customDockPanel1.Size = new System.Drawing.Size(194, 278);
            this.customDockPanel1.Text = "customDockPanel1";
            // 
            // customDockPanel1_Container
            // 
            this.customDockPanel1_Container.Location = new System.Drawing.Point(2, 24);
            this.customDockPanel1_Container.Name = "customDockPanel1_Container";
            this.customDockPanel1_Container.Size = new System.Drawing.Size(190, 252);
            this.customDockPanel1_Container.TabIndex = 0;
            // 
            // customDockPanel2
            // 
            this.customDockPanel2.Controls.Add(this.customDockPanel2_Container);
            this.customDockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.customDockPanel2.FloatSize = new System.Drawing.Size(173, 278);
            this.customDockPanel2.ID = new System.Guid("fc2aba31-ebdc-4daf-803d-3276ead3523b");
            this.customDockPanel2.Location = new System.Drawing.Point(195, 23);
            this.customDockPanel2.Name = "customDockPanel2";
            this.customDockPanel2.Size = new System.Drawing.Size(173, 278);
            this.customDockPanel2.Text = "customDockPanel2";
            // 
            // customDockPanel2_Container
            // 
            this.customDockPanel2_Container.Location = new System.Drawing.Point(2, 24);
            this.customDockPanel2_Container.Name = "customDockPanel2_Container";
            this.customDockPanel2_Container.Size = new System.Drawing.Size(169, 252);
            this.customDockPanel2_Container.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 475);
            this.Name = "Form1";
            this.Text = "ShowSpltContainerCaption";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customDockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.customDockPanel1.ResumeLayout(false);
            this.customDockPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDockManager customDockManager1;
        private CustomDockPanel panelContainer1;
        private CustomDockPanel customDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer customDockPanel1_Container;
        private CustomDockPanel customDockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer customDockPanel2_Container;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;

    }
}

