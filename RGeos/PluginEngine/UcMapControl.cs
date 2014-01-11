﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RGeos.Geometry;

namespace RGeos.PluginEngine
{
    public partial class UcMapControl : UserControl
    {
        public ITool CurrentTool = null;
        public IScreenDisplay mScreenDisplay;
        REnvelope mExtent;
        public Map mMap { get; set; }
        public UcMapControl()
        {
            mScreenDisplay = new ScreenDisplay();
            mScreenDisplay.Handle = Handle;
            InitializeComponent();
            mMap = new Map();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.MouseDown += new MouseEventHandler(mPanel_MouseDown);
            this.MouseMove += new MouseEventHandler(mPanel_MouseMove);
            this.MouseUp += new MouseEventHandler(mPanel_MouseUp);
        }

        //bool m_staticDirty = true;
        ////缓存图片？
        //Bitmap m_staticImage = null;
        System.Drawing.Drawing2D.SmoothingMode m_smoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
        protected override void OnPaint(PaintEventArgs e)
        {
            
            #region old
            //e.Graphics.SmoothingMode = m_smoothingMode;
            //Rectangle cliprectangle = e.ClipRectangle;
            //if (m_staticImage == null)
            //{
            //    cliprectangle = ClientRectangle;
            //    m_staticImage = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            //    //  m_staticImage.Save("D:\\a.png", ImageFormat.Png);
            //    m_staticDirty = true;
            //}
            ////绘制在背景图片上
            //Graphics BitMapGc = Graphics.FromImage(m_staticImage);
            //BitMapGc.SmoothingMode = m_smoothingMode;
            ////this.BackgroundLayer.Draw(dcStatic, r);
            ////if (m_model.GridLayer.Enabled)
            ////    m_model.GridLayer.Draw(dcStatic, r);
            ////绘制十字丝
            //RPoint rCenterPoint = new RPoint(0, 0, 0);
            //PointF nullPoint = Transform.ToScreen(rCenterPoint, this);
            //BitMapGc.DrawLine(Pens.Blue, nullPoint.X - 10, nullPoint.Y, nullPoint.X + 10, nullPoint.Y);
            //BitMapGc.DrawLine(Pens.Blue, nullPoint.X, nullPoint.Y - 10, nullPoint.X, nullPoint.Y + 10);
            //if (m_staticDirty)
            //{
            //    m_staticDirty = false;

            //    List<ILayer> layers = mMap.Layers;
            //    for (int layerindex = layers.Count - 1; layerindex >= 0; layerindex--)
            //    {
            //        if (layers[layerindex].Visible)
            //            layers[layerindex].Draw(mScreenDisplay);
            //    }
            //    BitMapGc.Dispose();
            //}
            ////绘制背景图片
            //e.Graphics.DrawImage(m_staticImage, cliprectangle, cliprectangle, GraphicsUnit.Pixel);
            #endregion
            e.Graphics.SmoothingMode = m_smoothingMode;
            mScreenDisplay.StartDrawing(this);
            mScreenDisplay.FinishDrawing(e.Graphics);
            if (mScreenDisplay.IsCacheDirty)
            {
                mScreenDisplay.StartRecording();
               
                mScreenDisplay.StopRecording();
            }
            else
            {
                mScreenDisplay.DrawCache();
            }
           

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (m_lastCenterPoint != null && Width != 0)
                SetCenterScreen(Transform.ToScreen(m_lastCenterPoint, this), false);
            m_lastCenterPoint = CenterPointUnit();
            (mScreenDisplay as ScreenDisplay).UpdateWindow();
           // m_staticImage = null;
            Invalidate();
        }
        RPoint m_lastCenterPoint;
        /// <summary>
        /// 设置画布到屏幕的中心
        /// </summary>
        /// <param name="rPoint">直角坐标系坐标</param>
        public void SetCenter(RPoint unitPoint)
        {
            PointF point = Transform.ToScreen(unitPoint, this);
            m_lastCenterPoint = unitPoint;
            SetCenterScreen(point, false);
        }
        public PointF m_panOffset = new PointF(25, -25);
        public PointF m_dragOffset = new PointF(0, 0);
        protected void SetCenterScreen(PointF screenPoint, bool setCursor)
        {
            float centerX = ClientRectangle.Width / 2;
            m_panOffset.X += centerX - screenPoint.X;

            float centerY = ClientRectangle.Height / 2;
            m_panOffset.Y += centerY - screenPoint.Y;

            if (setCursor)
                Cursor.Position = this.PointToScreen(new Point((int)centerX, (int)centerY));
            Invalidate();
        }
        public RPoint CenterPointUnit()
        {
            RPoint p1 = Transform.ToUnit(new PointF(0, 0), this);
            RPoint p2 = Transform.ToUnit(new PointF(this.ClientRectangle.Width, this.ClientRectangle.Height), this);
            RPoint center = new RPoint();
            center.X = (p1.X + p2.X) / 2;
            center.Y = (p1.Y + p2.Y) / 2;
            return center;
        }
        void mPanel_MouseUp(object sender, MouseEventArgs e)
        {
          //  base.OnMouseUp(e);
            if (CurrentTool != null)
            {
                CurrentTool.OnMouseUp(e.X, e.Y);
            }
        }

        void mPanel_MouseMove(object sender, MouseEventArgs e)
        {
           // base.OnMouseMove(e);
            if (CurrentTool != null)
            {
                CurrentTool.OnMouseMove(e.X, e.Y);
            }
        }

        void mPanel_MouseDown(object sender, MouseEventArgs e)
        {
          //  base.OnMouseDown(e);
            if (CurrentTool != null)
            {
                CurrentTool.OnMouseDown(e.X, e.Y);
            }
        }

        internal float ScreenHeight()
        {
            return (float)(Transform.ToUnit(this.ClientRectangle.Height, this));
        }
        private float mZoom = 1.0f;
        public float Zoom
        {
            get
            {
                return mZoom;
            }
            set
            {
                mZoom = value;
            }
        }
    }
}