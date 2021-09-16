using Airline.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class LineChartControl : Control
    {
        public LineChartValues[] Data { get; set; }

        public LineChartControl()
        {
            InitializeComponent();
            ResizeRedraw = true;

            Data = new[]
            {
                new LineChartValues("Flight id", 1),
                new LineChartValues("Flight id", 2),
                new LineChartValues("Flight id", 3)
            };
        }

        public LineChartControl(LineChartValues[] data)
        {
            InitializeComponent();
            ResizeRedraw = true;
            Data = data;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;
            Rectangle rectangle = pe.ClipRectangle;

            float scalingFactorX = (float)(rectangle.Width / Data.Length);
            float scalingFactorY = (float)(rectangle.Height / 10);

            Pen pen = new Pen(new SolidBrush(Color.Black));
            pen.StartCap = LineCap.ArrowAnchor;

            Pen pen2 = new Pen(new SolidBrush(Color.Black));
            pen2.EndCap = LineCap.RoundAnchor;

            graphics.DrawLine(pen, 0, 0, 0, rectangle.Height);
            graphics.DrawLine(pen, 0, rectangle.Height - 0.5f, rectangle.Width - 0.5f,
                rectangle.Height - 0.5f);

            for (int i = 0; i < Data.Length - 1; i++)
            {
                graphics.DrawLine(pen2,
                    i * scalingFactorX,
                    rectangle.Height - (Data[i].Value * scalingFactorY),
                    (i + 1) * scalingFactorX,
                    rectangle.Height - (Data[i + 1].Value * scalingFactorY));
            }
        }
    }
}
