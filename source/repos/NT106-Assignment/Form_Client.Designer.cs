using System.Drawing;
using System.Windows.Forms;

namespace NT106_Assignment
{
    partial class Form_Client
    {
        private System.ComponentModel.IContainer components = null;

        // layout
        private Panel root, body, header, left, right;

        // Player
        private Label lblPlayer;
        private FlowLayoutPanel playerList;

        // AlbumArt
        private Label lblAlbum;
        internal PictureBox pbCanvas;   // bảng vẽ
        internal Label lblPainting;

        // Guess (chỉ 1 dòng)
        private TableLayoutPanel guessRow;
        private TextBox guess1;
        internal Panel color1;

        // Toolbar
        private TableLayoutPanel tlToolbar;
        private Panel cardSave, cardTools, cardSize, cardShapes, cardColors;
        internal Button btnSave;
        internal CheckBox btnPen, btnEraser, btnThin, btnThick, btnLine, btnRect, btnEllipse;
        private Label lblColors;
        internal FlowLayoutPanel flowColors;
        internal Panel swatchBlack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SuspendLayout();

            // === FORM ===
            ClientSize = new Size(990, 620);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayArt";
            BackColor = Color.FromArgb(245, 245, 245);

            // === ROOT ===
            root = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(245, 231, 220), Padding = new Padding(6) };
            Controls.Add(root);

            // body dưới, header trên để toolbar không che
            body = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(200, 185, 255), Padding = new Padding(6) };
            header = new Panel { Dock = DockStyle.Top, Height = 90, BackColor = Color.FromArgb(245, 231, 220) };
            root.Controls.Add(body);
            root.Controls.Add(header);

            // === TOOLBAR ===
            tlToolbar = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 5, RowCount = 1 };
            for (int i = 0; i < 5; i++) tlToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            header.Controls.Add(tlToolbar);

            // Save
            cardSave = MakeCard();
            btnSave = new Button { Text = "✓", Font = new Font("Segoe UI", 20, FontStyle.Bold), Width = 56, Height = 56, Location = new Point(10, 8) };
            var lblSave = new Label { Text = "Save", Dock = DockStyle.Bottom, Height = 20, ForeColor = Color.Teal, TextAlign = ContentAlignment.MiddleLeft };
            cardSave.Controls.Add(btnSave); cardSave.Controls.Add(lblSave);
            tlToolbar.Controls.Add(cardSave, 0, 0);

            // Tools
            cardTools = MakeCard();
            btnPen = new CheckBox { Appearance = Appearance.Button, Text = "✎", Font = new Font("Segoe UI", 14, FontStyle.Bold), Width = 40, Height = 36, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(10, 14) };
            btnEraser = new CheckBox { Appearance = Appearance.Button, Text = "⌫", Font = new Font("Segoe UI", 14, FontStyle.Bold), Width = 40, Height = 36, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(56, 14) };
            var lblTools = new Label { Text = "Tools", Dock = DockStyle.Bottom, Height = 20, ForeColor = Color.Teal, TextAlign = ContentAlignment.MiddleLeft };
            cardTools.Controls.AddRange(new Control[] { btnPen, btnEraser, lblTools });
            tlToolbar.Controls.Add(cardTools, 1, 0);

            // Size
            cardSize = MakeCard();
            btnThin = new CheckBox { Appearance = Appearance.Button, Text = " ~ ", Width = 40, Height = 36, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(10, 14) };
            btnThick = new CheckBox { Appearance = Appearance.Button, Text = " ≈ ", Width = 40, Height = 36, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(56, 14) };
            var lblSize = new Label { Text = "Size", Dock = DockStyle.Bottom, Height = 20, ForeColor = Color.Teal, TextAlign = ContentAlignment.MiddleLeft };
            cardSize.Controls.AddRange(new Control[] { btnThin, btnThick, lblSize });
            tlToolbar.Controls.Add(cardSize, 2, 0);

            // Shapes
            cardShapes = MakeCard();
            btnLine = new CheckBox { Appearance = Appearance.Button, Text = "—", Width = 36, Height = 36, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(6, 14) };
            btnRect = new CheckBox { Appearance = Appearance.Button, Text = "▭", Width = 36, Height = 36, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(46, 14) };
            btnEllipse = new CheckBox { Appearance = Appearance.Button, Text = "◯", Width = 36, Height = 36, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(86, 14) };
            var lblShapes = new Label { Text = "Shapes", Dock = DockStyle.Bottom, Height = 20, ForeColor = Color.Teal, TextAlign = ContentAlignment.MiddleLeft };
            cardShapes.Controls.AddRange(new Control[] { btnLine, btnRect, btnEllipse, lblShapes });
            tlToolbar.Controls.Add(cardShapes, 3, 0);

            // Colors (label ở trên, không che)
            cardColors = MakeCard();
            lblColors = new Label { Text = "Colors", Dock = DockStyle.Top, Height = 18, ForeColor = Color.Teal, TextAlign = ContentAlignment.MiddleLeft };
            flowColors = new FlowLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(4, 2, 4, 4), WrapContents = true };
            cardColors.Controls.Add(flowColors);
            cardColors.Controls.Add(lblColors);
            tlToolbar.Controls.Add(cardColors, 4, 0);

            Color[] palette = { Color.Black, Color.White, Color.SandyBrown, Color.PaleVioletRed, Color.Khaki, Color.OrangeRed, Color.MediumPurple, Color.MediumSeaGreen, Color.SkyBlue, Color.Teal };
            for (int i = 0; i < palette.Length; i++)
            {
                var sw = new Panel { BackColor = palette[i], Margin = new Padding(6, 4, 6, 4), Size = new Size(22, 22), Cursor = Cursors.Hand };
                flowColors.Controls.Add(sw);
                if (i == 0) swatchBlack = sw;
            }

            // === NỘI DUNG: LEFT + RIGHT ===
            left = new Panel { Dock = DockStyle.Left, Width = 245, BackColor = Color.FromArgb(140, 120, 230), Padding = new Padding(10) };
            right = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(185, 165, 245), Padding = new Padding(24, 26, 24, 18) };
            body.Controls.Add(right); body.Controls.Add(left);

            // Left/Player
            lblPlayer = new Label { Text = "Player", Dock = DockStyle.Top, Height = 28, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.Cyan };
            playerList = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
            left.Controls.Add(playerList); left.Controls.Add(lblPlayer);
            playerList.Controls.Add(MakePlayerRow(Color.MediumSpringGreen, "Name_Player1"));
            playerList.Controls.Add(MakePlayerRow(Color.LightCoral, "Name_Player2"));
            playerList.Controls.Add(MakePlayerRow(Color.LimeGreen, "Name_Player3"));
            playerList.Controls.Add(MakePlayerRow(Color.Yellow, "Name_Player4"));
            playerList.Controls.Add(MakePlayerRow(Color.Silver, "Name_Player5"));

            // Right/AlbumArt
            lblAlbum = new Label { Text = "AlbumArt", Dock = DockStyle.Top, Height = 24, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(0, 170, 160) };
            right.Controls.Add(lblAlbum);

            // ----- Hàng đoán (1 dòng) -----
            guessRow = new TableLayoutPanel { Dock = DockStyle.Top, ColumnCount = 2, RowCount = 1, Height = 40, Margin = new Padding(0, 6, 0, 8) };
            guessRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            guessRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            right.Controls.Add(guessRow);

            guess1 = new TextBox { Dock = DockStyle.Fill, Text = "//painting guessing", Font = new Font("Segoe UI", 9), Margin = new Padding(0, 4, 8, 4) };
            color1 = new Panel { Dock = DockStyle.Fill, BackColor = Color.Salmon, Margin = new Padding(0, 4, 0, 4), Cursor = Cursors.Hand };
            guessRow.Controls.Add(guess1, 0, 0);
            guessRow.Controls.Add(color1, 1, 0);

            // ----- Bảng vẽ chiếm phần còn lại -----
            pbCanvas = new PictureBox { Dock = DockStyle.Fill, BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 0, 0, 0) };
            right.Controls.Add(pbCanvas);

            // chữ demo trên canvas
            lblPainting = new Label { AutoSize = true, Text = "Painting", Font = new Font("Segoe UI", 18, FontStyle.Bold | FontStyle.Italic), BackColor = Color.Bisque };
            pbCanvas.Controls.Add(lblPainting);

            ResumeLayout(false);
        }

        // Helpers
        private Panel MakeCard() =>
            new Panel { Margin = new Padding(6, 0, 6, 0), BackColor = Color.FromArgb(245, 231, 220), Height = 86, Dock = DockStyle.Fill, Padding = new Padding(10) };

        private Control MakePlayerRow(Color color, string name)
        {
            var row = new Panel { Width = 210, Height = 56, BackColor = Color.FromArgb(120, 100, 210), Margin = new Padding(0, 8, 0, 0), Padding = new Padding(8) };
            row.Controls.Add(new Panel { Size = new Size(34, 34), BackColor = color, BorderStyle = BorderStyle.FixedSingle, Location = new Point(8, 9) });
            row.Controls.Add(new Button { Text = name, Width = 130, Height = 34, Location = new Point(56, 9), FlatStyle = FlatStyle.Flat, BackColor = Color.White });
            return row;
        }
    }
}
