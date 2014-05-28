﻿namespace RGeos.Desktop
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspNewLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspLayerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDrawPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDrawPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDrawLine = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制多边形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPan = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labcoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.labCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tspClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.图层ToolStripMenuItem,
            this.tspDrawPolygon,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspNewLayer});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // tspNewLayer
            // 
            this.tspNewLayer.Image = ((System.Drawing.Image)(resources.GetObject("tspNewLayer.Image")));
            this.tspNewLayer.Name = "tspNewLayer";
            this.tspNewLayer.Size = new System.Drawing.Size(136, 22);
            this.tspNewLayer.Text = "新建要素类";
            this.tspNewLayer.Click += new System.EventHandler(this.tspNewLayer_Click);
            // 
            // 图层ToolStripMenuItem
            // 
            this.图层ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspLayerInfo});
            this.图层ToolStripMenuItem.Name = "图层ToolStripMenuItem";
            this.图层ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.图层ToolStripMenuItem.Text = "图层";
            // 
            // tspLayerInfo
            // 
            this.tspLayerInfo.Image = ((System.Drawing.Image)(resources.GetObject("tspLayerInfo.Image")));
            this.tspLayerInfo.Name = "tspLayerInfo";
            this.tspLayerInfo.Size = new System.Drawing.Size(124, 22);
            this.tspLayerInfo.Text = "图层信息";
            this.tspLayerInfo.Click += new System.EventHandler(this.tspLayerInfo_Click);
            // 
            // tspDrawPolygon
            // 
            this.tspDrawPolygon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspDrawPoint,
            this.tspDrawLine,
            this.绘制多边形ToolStripMenuItem,
            this.tspSelect,
            this.tspClear});
            this.tspDrawPolygon.Name = "tspDrawPolygon";
            this.tspDrawPolygon.Size = new System.Drawing.Size(44, 21);
            this.tspDrawPolygon.Text = "编辑";
            this.tspDrawPolygon.Click += new System.EventHandler(this.tspDrawPolygon_Click);
            // 
            // tspDrawPoint
            // 
            this.tspDrawPoint.Image = ((System.Drawing.Image)(resources.GetObject("tspDrawPoint.Image")));
            this.tspDrawPoint.Name = "tspDrawPoint";
            this.tspDrawPoint.Size = new System.Drawing.Size(152, 22);
            this.tspDrawPoint.Text = "绘制点";
            this.tspDrawPoint.Click += new System.EventHandler(this.tspDrawPoint_Click);
            // 
            // tspDrawLine
            // 
            this.tspDrawLine.Image = ((System.Drawing.Image)(resources.GetObject("tspDrawLine.Image")));
            this.tspDrawLine.Name = "tspDrawLine";
            this.tspDrawLine.Size = new System.Drawing.Size(152, 22);
            this.tspDrawLine.Text = "绘制线";
            this.tspDrawLine.Click += new System.EventHandler(this.tspDrawLine_Click);
            // 
            // 绘制多边形ToolStripMenuItem
            // 
            this.绘制多边形ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("绘制多边形ToolStripMenuItem.Image")));
            this.绘制多边形ToolStripMenuItem.Name = "绘制多边形ToolStripMenuItem";
            this.绘制多边形ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.绘制多边形ToolStripMenuItem.Text = "绘制多边形";
            // 
            // tspSelect
            // 
            this.tspSelect.Name = "tspSelect";
            this.tspSelect.Size = new System.Drawing.Size(152, 22);
            this.tspSelect.Text = "选择要素";
            this.tspSelect.Click += new System.EventHandler(this.tspSelect_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPan});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // tspPan
            // 
            this.tspPan.Image = ((System.Drawing.Image)(resources.GetObject("tspPan.Image")));
            this.tspPan.Name = "tspPan";
            this.tspPan.Size = new System.Drawing.Size(100, 22);
            this.tspPan.Text = "漫游";
            this.tspPan.Click += new System.EventHandler(this.tspPan_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // tspAbout
            // 
            this.tspAbout.Name = "tspAbout";
            this.tspAbout.Size = new System.Drawing.Size(141, 22);
            this.tspAbout.Text = "关于RGEOS";
            this.tspAbout.Click += new System.EventHandler(this.tspAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labInfo,
            this.toolStripStatusLabel2,
            this.labcoord,
            this.labCoordinate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labInfo
            // 
            this.labInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(32, 17);
            this.labInfo.Text = "就绪";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(703, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // labcoord
            // 
            this.labcoord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labcoord.Name = "labcoord";
            this.labcoord.Size = new System.Drawing.Size(44, 17);
            this.labcoord.Text = "坐标：";
            // 
            // labCoordinate
            // 
            this.labCoordinate.Name = "labCoordinate";
            this.labCoordinate.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 455);
            this.panel1.TabIndex = 2;
            // 
            // tspClear
            // 
            this.tspClear.Name = "tspClear";
            this.tspClear.Size = new System.Drawing.Size(152, 22);
            this.tspClear.Text = "清除选择";
            this.tspClear.Click += new System.EventHandler(this.tspClear_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "RGeos.Desktop";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspPan;
        private System.Windows.Forms.ToolStripMenuItem tspDrawPolygon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labcoord;
        private System.Windows.Forms.ToolStripStatusLabel labCoordinate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tspDrawLine;
        private System.Windows.Forms.ToolStripMenuItem 绘制多边形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspNewLayer;
        private System.Windows.Forms.ToolStripMenuItem tspDrawPoint;
        private System.Windows.Forms.ToolStripMenuItem 图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspLayerInfo;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspAbout;
        private System.Windows.Forms.ToolStripMenuItem tspSelect;
        private System.Windows.Forms.ToolStripMenuItem tspClear;
    }
}

