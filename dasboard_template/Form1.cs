using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dasboard_template.PAGES;

namespace dasboard_template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region topbar

        private const int HT_CAPTION = 0x2;
        private const int HT_LEFT = 0xA;
        private const int HT_RIGHT = 0xB;
        private const int HT_TOP = 0xC;
        private const int HT_TOPLEFT = 0xD;
        private const int HT_TOPRIGHT = 0xE;
        private const int HT_BOTTOM = 0xF;
        private const int HT_BOTTOMLEFT = 0x10;
        private const int HT_BOTTOMRIGHT = 0x11;
        private const int WM_NCHITTEST = 0x84;
        private const int resizeAreaSize = 10;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                var cursor = PointToClient(Cursor.Position);

                if (cursor.X <= resizeAreaSize && cursor.Y <= resizeAreaSize)
                    m.Result = (IntPtr)HT_TOPLEFT;
                else if (cursor.X >= ClientSize.Width - resizeAreaSize && cursor.Y <= resizeAreaSize)
                    m.Result = (IntPtr)HT_TOPRIGHT;
                else if (cursor.X <= resizeAreaSize && cursor.Y >= ClientSize.Height - resizeAreaSize)
                    m.Result = (IntPtr)HT_BOTTOMLEFT;
                else if (cursor.X >= ClientSize.Width - resizeAreaSize && cursor.Y >= ClientSize.Height - resizeAreaSize)
                    m.Result = (IntPtr)HT_BOTTOMRIGHT;
                else if (cursor.X <= resizeAreaSize)
                    m.Result = (IntPtr)HT_LEFT;
                else if (cursor.X >= ClientSize.Width - resizeAreaSize)
                    m.Result = (IntPtr)HT_RIGHT;
                else if (cursor.Y <= resizeAreaSize)
                    m.Result = (IntPtr)HT_TOP;
                else if (cursor.Y >= ClientSize.Height - resizeAreaSize)
                    m.Result = (IntPtr)HT_BOTTOM;
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void windowstatemaxbutton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
           
        }
        private void windowstatusminbutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        #region pages
        PAGE1 page1 = new PAGE1();
        PAGE2 page2 = new PAGE2();
        PAGE3 page3 = new PAGE3();
        settings_page settings_Page = new settings_page();
        private void btnpage_1_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();
            page_panel.Controls.Add(page1);
        }
        private void btnpage_2_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();
            page_panel.Controls.Add(page2);
        }
        private void btnpage_3_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();
            page_panel.Controls.Add(page3);
        }

        private void btnsettingspage_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();
            page_panel.Controls.Add(settings_Page);
        }
        #endregion

        private void page_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
