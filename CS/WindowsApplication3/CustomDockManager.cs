using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraBars.Docking;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraBars.Docking.Helpers;
using System.Drawing;

namespace DXSample {
    public class CustomDockManager: DockManager {
        public CustomDockManager() : base() { }
        public CustomDockManager(ContainerControl form) : base(form) { }
        public CustomDockManager(IContainer container) : base(container) { }
        protected override DockPanel CreateDockPanel(DockingStyle dock, bool createControlContainer) {
            return new CustomDockPanel(createControlContainer, dock, this);
        }

        bool showSplitContainerCaptionAlways = false;

        public bool ShowSplitContainerCaptionAlways {
            get { return showSplitContainerCaptionAlways; }
            set {
                if(showSplitContainerCaptionAlways != value)
                    showSplitContainerCaptionAlways = value;
            }
        }
    }

    public class CustomDockPanel: DockPanel {
        public CustomDockPanel()
            : this(false, DockingStyle.Float, null) {
        }
        public CustomDockPanel(bool createControlContainer, DockingStyle dock, DockManager dockManager)
            : base(createControlContainer, dock, dockManager) {
            DockLayout = new CustomDockLayout(dock, this);
        }

    }

    public class CustomDockLayout: DockLayout {
        public CustomDockLayout(DockingStyle dock, DockPanel panel) : base(dock, panel) { }
        public CustomDockLayout(DockingStyle dock, Size size, DockPanel panel) : base(dock, size, panel) { }
        protected override bool HasCaption {
            get {
                if(DockManager.ShowSplitContainerCaptionAlways && HasChildren) return true;
                return base.HasCaption;
            }
        }

        public new CustomDockManager DockManager {
            get {return  base.DockManager as CustomDockManager; }
        }
        
    }
}
