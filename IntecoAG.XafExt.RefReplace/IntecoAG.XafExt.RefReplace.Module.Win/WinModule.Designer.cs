﻿namespace IntecoAG.XafExt.RefReplace.Module.Win {
    partial class RefReplaceWindowsFormsModule {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // RefReplaceWindowsFormsModule
            // 
            //this.RequiredModuleTypes.Add(typeof(IntecoAG.XafExt.RefReplace.Test.Module.TestModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule));
        }

        #endregion
    }
}