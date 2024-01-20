using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeVisualizer
{
    public partial class MainWindow : Form
    {
        private DrawBox _avlDrawBox;

        private AVLTree<int> _avlTree0;
        private AVLTree<int> _avlTree1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _avlDrawBox = new DrawBox
            {
                Dock = DockStyle.Fill
            };

            _avlTree0 = new AVLTree<int>(new TreeConfiguration(circleDiameter: 45, arrowAnchorSize: 5));
            _avlTree1 = new AVLTree<int>(new TreeConfiguration(circleDiameter: 45, arrowAnchorSize: 5));

            panel.Controls.Add(_avlDrawBox);
        }

        private async void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Insert.Text))
            {
                MessageBox.Show("Bạn quên nhập giá trị rồi !!", "Thông báo");
                return;
            }
            if (!int.TryParse(txt_Insert.Text, out int value))
            {
                MessageBox.Show($"Giá trị phải thuộc {typeof(int)}", "Error");
                return;
            }
            if (_avlTree1.Find(value))
            {
                MessageBox.Show($"Giá trị đã tồn tại", "Thông báo");
                return;
            }        
                        
            _avlTree0.Insert0(value);
            _avlTree1.Insert(value);

            _avlDrawBox.Print0<AVLTree<int>>(_avlTree0);

            await Task.Delay(2000);

            _avlDrawBox.Print0<AVLTree<int>>(_avlTree1);

            _avlTree0._root = _avlTree0.Copy(_avlTree0._root,_avlTree1._root);
        }

        private async void btn_Remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Remove.Text))
            {
                MessageBox.Show("Bạn quên nhập giá trị rồi !!", "Thông báo");
                return;
            }
            if (!int.TryParse(txt_Remove.Text, out int value))
            {
                MessageBox.Show($"Giá trị phải thuộc {typeof(int)}", "Error");
                return;
            }
            if (!_avlTree1.Find(value))
            {
                MessageBox.Show($"Giá trị không tồn tại", "Thông báo");
                return;
            }

            _avlTree0.Remove0(value);
            _avlDrawBox.Print0<AVLTree<int>>(_avlTree0);

            await Task.Delay(2000);

            _avlTree1.Remove(value);
            _avlDrawBox.Print0<AVLTree<int>>(_avlTree1);

            _avlTree0._root = _avlTree0.Copy(_avlTree0._root, _avlTree1._root);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text))
            {
                MessageBox.Show("Bạn quên nhập giá trị rồi !!", "Thông báo");
                return;
            }
            if (!int.TryParse(txt_Search.Text, out int value))
            {
                MessageBox.Show($"Giá trị phải thuộc {typeof(int)}", "Error");
                return;
            }
            if (!_avlTree1.Find(value))
            {
                MessageBox.Show($"Giá trị không tồn tại", "Thông báo");
                return;
            }

            _avlDrawBox.Print1<AVLTree<int>, int> (_avlTree1, int.Parse(txt_Search.Text));
        }
    }
}
