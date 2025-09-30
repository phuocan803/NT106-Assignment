using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace NT106_Assignment
{
    public partial class Form_Client : Form
    {
        // ====== STATE ======
        private enum Tool { Pen, Eraser, Line, Rect, Ellipse }
        private Tool currentTool = Tool.Pen;
        private Color currentColor = Color.Black;
        private int penWidth = 3; // thin=3, thick=10

        private Bitmap surface;      // lớp vẽ chính
        private Bitmap previewLayer; // lớp preview cho shape
        private Point ptStart, ptLast;
        private bool isDrawing;

        public Form_Client()
        {
            InitializeComponent();

            // ===== Toolbar wiring =====
            btnSave.Click += delegate { SaveCanvas(); };

            btnPen.Checked = true;
            btnPen.CheckedChanged += delegate { if (btnPen.Checked) { currentTool = Tool.Pen; UpdateToolButtons(); } };
            btnEraser.CheckedChanged += delegate { if (btnEraser.Checked) { currentTool = Tool.Eraser; UpdateToolButtons(); } };

            btnThin.Checked = true;
            btnThin.CheckedChanged += delegate { if (btnThin.Checked) { penWidth = 3; UpdateSizeButtons(); } };
            btnThick.CheckedChanged += delegate { if (btnThick.Checked) { penWidth = 10; UpdateSizeButtons(); } };

            btnLine.CheckedChanged += delegate { if (btnLine.Checked) { currentTool = Tool.Line; UpdateToolButtons(); } };
            btnRect.CheckedChanged += delegate { if (btnRect.Checked) { currentTool = Tool.Rect; UpdateToolButtons(); } };
            btnEllipse.CheckedChanged += delegate { if (btnEllipse.Checked) { currentTool = Tool.Ellipse; UpdateToolButtons(); } };

            foreach (Control c in flowColors.Controls)
            {
                Panel sw = c as Panel;
                if (sw != null)
                {
                    sw.Click += delegate { currentColor = sw.BackColor; HighlightSwatch(sw); };
                }
            }

            pbCanvas.Cursor = Cursors.Cross;

            // ===== Canvas =====
            EnsureSurface();                         // lần 1 (có thể form còn nhỏ)
            pbCanvas.Resize += delegate { EnsureSurface(); };
            this.Shown += delegate { EnsureSurface(); }; // lần 2 sau layout

            // Sự kiện vẽ
            pbCanvas.MouseDown += PbCanvas_MouseDown;
            pbCanvas.MouseMove += PbCanvas_MouseMove;
            pbCanvas.MouseUp += PbCanvas_MouseUp;

            // Căn label demo
            this.Load += delegate
            {
                lblPainting.Location = new Point(
                    (pbCanvas.Width - lblPainting.Width) / 2,
                    (pbCanvas.Height - lblPainting.Height) / 2);
            };

            HighlightSwatch(swatchBlack);
        }

        // ====== ENSURE SURFACE ======
        private void EnsureSurface()
        {
            if (pbCanvas.Width <= 1 || pbCanvas.Height <= 1) return;

            if (surface == null || surface.Width != pbCanvas.Width || surface.Height != pbCanvas.Height)
            {
                if (pbCanvas.Image != null) pbCanvas.Image = null;
                if (surface != null) surface.Dispose();
                if (previewLayer != null) previewLayer.Dispose();

                surface = new Bitmap(pbCanvas.Width, pbCanvas.Height);
                previewLayer = new Bitmap(pbCanvas.Width, pbCanvas.Height);
                pbCanvas.Image = surface;
            }
        }

        // ====== MOUSE HANDLERS ======
        private void PbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            EnsureSurface();
            if (surface == null) return;

            if (lblPainting.Visible) lblPainting.Visible = false; // tránh chặn chuột

            isDrawing = true;
            ptStart = ptLast = e.Location;

            if (currentTool == Tool.Pen || currentTool == Tool.Eraser)
            {
                using (Graphics g = Graphics.FromImage(surface))
                using (Pen p = MakePen())
                {
                    p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(p, ptLast, new Point(ptLast.X + 1, ptLast.Y + 1));
                }
                pbCanvas.Invalidate();
            }
        }

        private void PbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing || surface == null) return;

            if (currentTool == Tool.Pen || currentTool == Tool.Eraser)
            {
                using (Graphics g = Graphics.FromImage(surface))
                using (Pen p = MakePen())
                {
                    p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(p, ptLast, e.Location);
                }
                ptLast = e.Location;
                pbCanvas.Invalidate();
            }
            else
            {
                // Preview shape
                if (previewLayer != null) previewLayer.Dispose();
                previewLayer = (Bitmap)surface.Clone();

                using (Graphics g = Graphics.FromImage(previewLayer))
                using (Pen p = MakePen())
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Rectangle rc = ToRect(ptStart, e.Location);
                    if (currentTool == Tool.Line) g.DrawLine(p, ptStart, e.Location);
                    else if (currentTool == Tool.Rect) g.DrawRectangle(p, rc);
                    else if (currentTool == Tool.Ellipse) g.DrawEllipse(p, rc);
                }
                pbCanvas.Image = previewLayer;
            }
        }

        private void PbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing || surface == null) return;
            isDrawing = false;

            if (currentTool == Tool.Line || currentTool == Tool.Rect || currentTool == Tool.Ellipse)
            {
                using (Graphics g = Graphics.FromImage(surface))
                using (Pen p = MakePen())
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Rectangle rc = ToRect(ptStart, e.Location);
                    if (currentTool == Tool.Line) g.DrawLine(p, ptStart, e.Location);
                    else if (currentTool == Tool.Rect) g.DrawRectangle(p, rc);
                    else if (currentTool == Tool.Ellipse) g.DrawEllipse(p, rc);
                }
                pbCanvas.Image = surface;
                pbCanvas.Invalidate();
            }
        }

        // ====== HELPERS ======
        private Pen MakePen()
        {
            if (currentTool == Tool.Eraser) return new Pen(Color.White, penWidth);
            return new Pen(currentColor, penWidth);
        }

        private static Rectangle ToRect(Point a, Point b)
        {
            int x = Math.Min(a.X, b.X);
            int y = Math.Min(a.Y, b.Y);
            int w = Math.Abs(a.X - b.X);
            int h = Math.Abs(a.Y - b.Y);
            return new Rectangle(x, y, w, h);
        }

        // ====== SAVE ======
        private void SaveCanvas()
        {
            if (surface == null) return;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap|*.bmp";
                sfd.FileName = "KayArt.png";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    ImageFormat fmt = ImageFormat.Png;
                    if (sfd.FilterIndex == 2) fmt = ImageFormat.Jpeg;
                    if (sfd.FilterIndex == 3) fmt = ImageFormat.Bmp;
                    surface.Save(sfd.FileName, fmt);
                }
            }
        }

        // ====== DISPOSE ======
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pbCanvas.Image = null;
            if (surface != null) surface.Dispose();
            if (previewLayer != null) previewLayer.Dispose();
            base.OnFormClosed(e);
        }

        // ====== UI STATE ======
        private void UpdateToolButtons()
        {
            btnPen.Checked = (currentTool == Tool.Pen);
            btnEraser.Checked = (currentTool == Tool.Eraser);
            btnLine.Checked = (currentTool == Tool.Line);
            btnRect.Checked = (currentTool == Tool.Rect);
            btnEllipse.Checked = (currentTool == Tool.Ellipse);
        }

        private void UpdateSizeButtons()
        {
            btnThin.Checked = (penWidth <= 3);
            btnThick.Checked = (penWidth >= 10);
        }

        private void HighlightSwatch(Panel chosen)
        {
            foreach (Control c in flowColors.Controls)
            {
                Panel p = c as Panel;
                if (p != null) p.BorderStyle = BorderStyle.None;
            }
            chosen.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
