﻿namespace Platinum.PropertyEditors
{
    partial class EnumEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._customSourceListEditor = new PropertyEditors.CustomSourceListEditor();
            this.SuspendLayout();
            // 
            // _customSourceListEditor
            // 
            this._customSourceListEditor.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._customSourceListEditor.Font = new System.Drawing.Font( "Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this._customSourceListEditor.ItemNameProvider = null;
            this._customSourceListEditor.ItemSource = null;
            this._customSourceListEditor.Location = new System.Drawing.Point( 0, 0 );
            this._customSourceListEditor.Name = "_customSourceListEditor";
            this._customSourceListEditor.Size = new System.Drawing.Size( 256, 19 );
            this._customSourceListEditor.TabIndex = 0;
            // 
            // EnumEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this._customSourceListEditor );
            this.Name = "EnumEditor";
            this.Size = new System.Drawing.Size( 256, 19 );
            this.ResumeLayout( false );

        }

        #endregion

        private CustomSourceListEditor _customSourceListEditor;
    }
}