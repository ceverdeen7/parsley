﻿namespace Parsley {
  partial class IntrinsicCalibrationSlide {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntrinsicCalibrationSlide));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this._cb_auto_take = new System.Windows.Forms.CheckBox();
      this._btn_take_image = new Parsley.UI.ParsleyButton();
      this._btn_calibrate = new Parsley.UI.ParsleyButton();
      this._lbl_info = new Parsley.UI.GrowLabel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 441F));
      this.tableLayoutPanel1.Controls.Add(this._cb_auto_take, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this._btn_take_image, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this._btn_calibrate, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this._lbl_info, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 370);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // _cb_auto_take
      // 
      this._cb_auto_take.Anchor = System.Windows.Forms.AnchorStyles.None;
      this._cb_auto_take.AutoSize = true;
      this._cb_auto_take.Location = new System.Drawing.Point(147, 116);
      this._cb_auto_take.Name = "_cb_auto_take";
      this._cb_auto_take.Size = new System.Drawing.Size(147, 23);
      this._cb_auto_take.TabIndex = 9;
      this._cb_auto_take.Text = "Auto take images";
      this._cb_auto_take.UseVisualStyleBackColor = true;
      this._cb_auto_take.CheckedChanged += new System.EventHandler(this._cb_auto_take_CheckedChanged);
      // 
      // _btn_take_image
      // 
      this._btn_take_image.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this._btn_take_image.BackColor = System.Drawing.Color.White;
      this._btn_take_image.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this._btn_take_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this._btn_take_image.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_take_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this._btn_take_image.Image = ((System.Drawing.Image)(resources.GetObject("_btn_take_image.Image")));
      this._btn_take_image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_take_image.Location = new System.Drawing.Point(70, 50);
      this._btn_take_image.Name = "_btn_take_image";
      this._btn_take_image.Size = new System.Drawing.Size(300, 60);
      this._btn_take_image.TabIndex = 8;
      this._btn_take_image.Text = "Take Image";
      this._btn_take_image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_take_image.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this._btn_take_image.UseVisualStyleBackColor = true;
      this._btn_take_image.Click += new System.EventHandler(this._btn_take_image_Click);
      // 
      // _btn_calibrate
      // 
      this._btn_calibrate.Anchor = System.Windows.Forms.AnchorStyles.None;
      this._btn_calibrate.BackColor = System.Drawing.Color.White;
      this._btn_calibrate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this._btn_calibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this._btn_calibrate.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_calibrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this._btn_calibrate.Image = ((System.Drawing.Image)(resources.GetObject("_btn_calibrate.Image")));
      this._btn_calibrate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_calibrate.Location = new System.Drawing.Point(70, 282);
      this._btn_calibrate.Name = "_btn_calibrate";
      this._btn_calibrate.Size = new System.Drawing.Size(300, 60);
      this._btn_calibrate.TabIndex = 2;
      this._btn_calibrate.Text = "Calibrate";
      this._btn_calibrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_calibrate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this._btn_calibrate.UseVisualStyleBackColor = true;
      this._btn_calibrate.Click += new System.EventHandler(this._btn_calibrate_Click);
      // 
      // _lbl_info
      // 
      this._lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None;
      this._lbl_info.Location = new System.Drawing.Point(70, 179);
      this._lbl_info.Name = "_lbl_info";
      this._lbl_info.Size = new System.Drawing.Size(300, 38);
      this._lbl_info.TabIndex = 4;
      this._lbl_info.Text = "Start the calibration process by taking images";
      // 
      // IntrinsicCalibrationSlide
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "IntrinsicCalibrationSlide";
      this.Size = new System.Drawing.Size(441, 370);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private Parsley.UI.ParsleyButton _btn_calibrate;
    private Parsley.UI.GrowLabel _lbl_info;
    private Parsley.UI.ParsleyButton _btn_take_image;
    private System.Windows.Forms.CheckBox _cb_auto_take;
  }
}
