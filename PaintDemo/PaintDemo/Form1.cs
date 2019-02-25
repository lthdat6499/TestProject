using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PaintDemo
{
    public partial class Form1 : Form
    {
        // Note: các chế độ sẽ dùng Text để phần biệt và chọn
        // Quy trình vẽ: Khởi tạo và add vào list các đối tượng đồ họa -> xác định chế độ vẽ -> vẽ hoặc fill


        Graphics g;
        Pen pen;
        SolidBrush Co;
        // Moving object
        Point p1;
        Point p2;
        // Kiểu vẽ: hình tròn, vuông, ...
        string kieuve;
        // Chế độ tô đầy / bình thường
        string chedo;
        // Kiểu bút: nét đứt, liền, ...
        string kieubut;
        // Lỗi null kiểu vẽ
        bool isfirsttime = true;
        // Xác nhận đang move chuột
        bool isReadyToMove = false;
        // Xác nhận đang chấm màn hình để vẽ đa giác
        bool isDrawingPolygon = false;
        // Xác nhận chọn đối tượng và sẽ di chuyển bằng chuột
        bool isMoving = false;
        // Xác nhân đang di chuyển đối tượng
        bool isMousing = false;
        // Danh sách đối tượng đồ họa đã vẽ
        List<C_DrawObject> listObject = new List<C_DrawObject>();

        public Form1()
        {
            InitializeComponent();
            // Chọn kiểu vẽ nét liền
            cbx_KieuVe.SelectedIndex = 0;
            // Khởi tạo đối tượng đồ họa cho panel
            g = pnl_Board.CreateGraphics();
            // Set màu mặc định và kiểu vẽ mặc định cho bút
            pen = new Pen(btn_Mau.BackColor, tbr_DoDayBut.Value);
            // Khởi tạo cọ với màu mặc định
            Co = new SolidBrush(pen.Color);
            // Set các chế độ, kiểu vẽ mặc định
            chedo = rbt_CheDo.Text;
            kieuve = rbt_DuongThang.Text;
            // Xác nhận đã chạy lần đầu xong
            isfirsttime = false;
        }

        #region Vẽ hình
        private void pnl_Board_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ ra tất cả đối tượng trong list
            for (int i = 0; i < listObject.Count; i++)
            {
                if (listObject[i].isFill)
                    listObject[i].Fill(g);
                else
                    listObject[i].Draw(g);
            }
        }
        private void CopyPen(Pen MyPen, SolidBrush MyBrush)
        {
            MyPen.Color = pen.Color;
            MyPen.Width = pen.Width;
            MyPen.DashStyle = pen.DashStyle;
            MyBrush.Color = pen.Color;
        }
        private void pnl_Board_MouseDown(object sender, MouseEventArgs e)
        {
            // Nếu không phải đang vẽ đa giác thì 
            if (isMoving == false)
            {
                if (isDrawingPolygon == false)
                {
                    // Cấu trúc:
                    // Tạo đối tượng -> tạo điểm đầu tiên 
                    //-> Copy pen -> thêm vào danh sách đối tượng đồ họa
                    //-> thêm vào đánh dấu trong listbox 
                    switch (kieuve)
                    {
                        case "Vẽ đường thẳng":
                            C_DrawObject MyLine = new C_Line();
                            listObject.Add(MyLine);
                            lbx_Object.Items.Add("Line " + pen.Color);
                            break;
                        case "Vẽ hình Ellipse":
                            C_DrawObject MyEllipse = new C_Ellipse();
                            listObject.Add(MyEllipse);
                            lbx_Object.Items.Add("Ellipse " + pen.Color);
                            break;
                        case "Vẽ hình tròn":
                            C_DrawObject MyCircle = new C_Circle();
                            listObject.Add(MyCircle);
                            lbx_Object.Items.Add("Circle " + pen.Color);
                            break;
                        case "Vẽ hình Chữ Nhật":
                            C_DrawObject MyRectangle = new C_Rectangle();
                            listObject.Add(MyRectangle);
                            lbx_Object.Items.Add("Rectangle " + pen.Color);
                            break;
                        case "Vẽ hình vuông":
                            C_DrawObject MySquare = new C_Square();
                            listObject.Add(MySquare);
                            lbx_Object.Items.Add("Square " + pen.Color);
                            break;
                        case "Vẽ đường cong":
                            C_DrawObject MyCurve = new C_Curve();
                            MyCurve.point.Add(e.Location);
                            listObject.Add(MyCurve);
                            lbx_Object.Items.Add("Curve " + pen.Color);
                            break;
                        case "Vẽ đa giác":
                            isDrawingPolygon = true;
                            C_DrawObject MyPolygon = new C_Polygon();
                            MyPolygon.point.Add(e.Location);
                            listObject.Add(MyPolygon);
                            lbx_Object.Items.Add("Polygon " + pen.Color);
                            break;

                    }
                    listObject[listObject.Count - 1].p1 = e.Location;
                    CopyPen(listObject[listObject.Count - 1].pen, listObject[listObject.Count - 1].brush);
                    if (chedo != "Chế độ bình thường")
                        listObject[listObject.Count - 1].isFill = true;
                    // Xác nhận mốc để di chuyển chuột
                    isReadyToMove = true;
                }
                // Nếu là vẽ đa giác thì chỉ được chấm chấm trên panel
                else
                {
                    // thêm điểm chấm vào mảng
                    listObject[listObject.Count - 1].point.Add(e.Location);
                    pnl_Board.Refresh();
                }
                if (lbx_Object.Items.Count != 0)
                {
                    lbx_Object.SelectedIndex = 0;
                }
            }
            else
            {
                p1 = e.Location;
                isMousing = true;
            }
        }
        private void pnl_Board_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving == false)
            {
                // Nếu đã xác nhận điểm đầu và không phải đang vẽ đa giác thì kiểm tra
                if (isReadyToMove == true && isDrawingPolygon == false)
                {
                    // Nếu khác kiểu vẽ đường cong thì
                    if (kieuve != "Vẽ đường cong")
                    {
                        // Di chuyển p2
                        listObject[listObject.Count - 1].p2 = e.Location;
                        pnl_Board.Refresh();
                    }
                    else
                    {
                        // Thêm điểm p2
                        listObject[listObject.Count - 1].point.Add(e.Location);
                        pnl_Board.Refresh();
                    }
                }
            }
            else if (isMousing == true)
            {

                p2 = e.Location;
                // Tính độ thay đổi giữa 2 x y
                int deltaX = p2.X - p1.X;
                int deltaY = p2.Y - p1.Y;
                // Đặt lại vị trí đầu thành vị trí hiện tại nếu không vị trí sẽ tăng hoặc giảm theo cấp số cộng
                p1 = p2;

                listObject[lbx_Object.SelectedIndex].p1.X += deltaX;
                listObject[lbx_Object.SelectedIndex].p1.Y += deltaY;
                listObject[lbx_Object.SelectedIndex].p2.X += deltaX;
                listObject[lbx_Object.SelectedIndex].p2.Y += deltaY;
                pnl_Board.Refresh();
            }
        }
        private void pnl_Board_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving == false)
            {
                // Nếu không phải đang vẽ đa giác thì
                if (isDrawingPolygon == false)
                {
                    // Xác nhận đã di chuyển chuột xong
                    isReadyToMove = false;
                    // Nếu là vẽ bth thì xác nhận điểm p2
                    if (kieuve != "Vẽ đường cong")
                    {
                        listObject[listObject.Count - 1].p2 = e.Location;
                    }
                    // Nếu là vẽ đường cong thì thêm điểm p2
                    else
                    {
                        listObject[listObject.Count - 1].point.Add(e.Location);
                    }
                    pnl_Board.Refresh();
                }
            }
            else
            {
                isMousing = false;
            }
        }
        private void btn_DungChamDaGiac_Click(object sender, EventArgs e)
        {
            // Trả lại trạng thái cũ của Groupbox và check đường thẳng mặc định
            gbx_TuyChinh.Enabled = true;
            rbt_HinhTron.Checked = true;
            gbx_KieuVe.Enabled = true;
            gbx_TuyChinh.Enabled = true;
            gbx_TinhChinh.Enabled = true;
            // Ẩn nút dừng vẽ đa giác
            btn_DungChamDaGiac.Visible = false;

            // Xác nhận dừng vẽ đa giác
            isDrawingPolygon = false;
            isReadyToMove = false;
        }
        #endregion

        #region Set màu
        private void btn_Mau_Click(object sender, EventArgs e)
        {
            Button Mau = sender as Button;
            btn_Mau.BackColor = Mau.BackColor;
            SetMau();
            pnl_Board.Refresh();
        }
        private void btn_TuyChinhMau_Click(object sender, EventArgs e)
        {
            if (cdl_ChooseColor.ShowDialog() == DialogResult.OK)
            {
                btn_Mau.BackColor = cdl_ChooseColor.Color;
                SetMau();
                pnl_Board.Refresh();
            }
        }

        private void SetMau()
        {
            Co.Color = pen.Color = btn_Mau.BackColor;
        }
        #endregion

        #region Độ dày, kiểu vẽ, chế độ
        private void tbr_DoDayBut_Scroll(object sender, EventArgs e)
        {
            // Đồ dày bằng giá trị của trackbar
            pen.Width = tbr_DoDayBut.Value;
        }

        private void rbt_KieuVe_Click(object sender, EventArgs e)
        {
            // ép kiểu sender
            RadioButton rbt = sender as RadioButton;
            kieuve = rbt.Text;
            // Nếu là vẽ đa giác thì
            if (kieuve == "Vẽ đa giác")
            {
                // tắt groupbox chọn kiểu vẽ và tùy chỉnh, tinh chỉnh
                gbx_KieuVe.Enabled = false;
                gbx_TuyChinh.Enabled = false;
                gbx_TinhChinh.Enabled = false;
                // tắt chọn chế độ vẽ
                gbx_TuyChinh.Enabled = false;
                // hiện nút tắt chế độ vẽ
                btn_DungChamDaGiac.Visible = true;
                // bỏ chọn đa giác để chống lỗi khóa groupbox vì dấu check sẽ luôn ở đa giác
                rbt.Checked = false;
                
            }
                
        }

        private void rbt_CheDo_Click(object sender, EventArgs e)
        {
            RadioButton rbt = sender as RadioButton;
            chedo = rbt.Text;
            if (chedo == "Chế độ bình thường")
            {
                rbt_DuongCong.Visible = rbt_DuongThang.Visible = true;
                rbt_DuongThang.Checked = true;
                kieuve = rbt_DuongThang.Text;
            }
            else
            {
                rbt_DuongCong.Visible = rbt_DuongThang.Visible = false;
                rbt_HinhTron.Checked = true;
                kieuve = rbt_HinhTron.Text;
            }
        }

        private void cbx_KieuVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            kieubut = cbx_KieuVe.SelectedItem.ToString();
            if (isfirsttime == false)
            {
                switch (kieubut)
                {
                    case "Nét liền":
                        pen.DashStyle = DashStyle.Solid;
                        break;
                    case "Nét đứt":
                        pen.DashStyle = DashStyle.Dash;
                        break;
                    case "Nét chấm":
                        pen.DashStyle = DashStyle.Dot;
                        break;
                    case "Nét đứt chấm":
                        pen.DashStyle = DashStyle.DashDot;
                        break;
                    case "Nét dứt chấm chấm":
                        pen.DashStyle = DashStyle.DashDotDot;
                        break;
                }
            }
            
        }
        #endregion

        #region Nâng cao
        private void btn_XoaObject_Click(object sender, EventArgs e)
        {
            // Nếu đang trong chế độ tùy chỉnh
            if (lbx_Object.Items.Count != 0)
            {
                listObject.RemoveAt(lbx_Object.SelectedIndex);
                lbx_Object.Items.RemoveAt(lbx_Object.SelectedIndex);
                pnl_Board.Refresh();
                if (lbx_Object.Items.Count != 0)
                    lbx_Object.SelectedIndex = 0;
            }
        }
        private void btn_ClearObject_Click(object sender, EventArgs e)
        {
            if (lbx_Object.Items.Count != 0)
            {
                listObject.Clear();
                lbx_Object.Items.Clear();
                pnl_Board.Refresh();
            }
        }
        private void btn_DiChuyen_Click(object sender, EventArgs e)
        {
            if (lbx_Object.Items.Count != 0 && btn_DiChuyen.Text == "Di chuyển")
            {
                // Xác nhận đang di chuyển
                isMoving = true;
                // Đổi tên nút
                btn_DiChuyen.Text = "Hoàn thành";
                gbx_KieuVe.Enabled = false;
            }
            else
            {
                // Xác nhận đang di chuyển
                isMoving = false;
                // Đổi tên nút
                btn_DiChuyen.Text = "Di chuyển";
                gbx_KieuVe.Enabled = true;
            }
        }
        private void tbr_Scale_Scroll(object sender, EventArgs e)
        {
            g.ResetTransform();
            float scale = tbr_Scale.Value;
            if (scale == 0)
                return;
            if (scale > 10)
            {
                scale = 1 + (scale - 10) / 10;
            }
            else
            {
                scale /= 10;
            }
            g.ScaleTransform(scale, scale);

            pnl_Board.Refresh();
        }
        #endregion
    }
}

