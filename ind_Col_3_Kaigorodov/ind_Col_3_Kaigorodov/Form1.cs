using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ind_Col_3_Kaigorodov
{
    public partial class Form1 : Form
    {
        private List<Vector3D> vectors = new List<Vector3D>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(txtX1.Text);
                double y1 = double.Parse(txtY1.Text);
                double z1 = double.Parse(txtZ1.Text);
                double x2 = double.Parse(txtX2.Text);
                double y2 = double.Parse(txtY2.Text);
                double z2 = double.Parse(txtZ2.Text);

                vectors.Add(new Vector3D(x1, y1, z1, x2, y2, z2));
                UpdateList();
                lblResult.Text = $"Вектор добавлен: ({x2 - x1:F2}; {y2 - y1:F2}; {z2 - z1:F2})";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int i1 = (int)numIndex1.Value;
            int i2 = (int)numIndex2.Value;

            if (i1 < vectors.Count && i2 < vectors.Count)
            {
                Vector3D result = vectors[i1] + vectors[i2];
                lblResult.Text = $"{vectors[i1]} + {vectors[i2]} = {result}";
            }
            else
            {
                MessageBox.Show("Неверный индекс вектора!");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int i1 = (int)numIndex1.Value;
            int i2 = (int)numIndex2.Value;

            if (i1 < vectors.Count && i2 < vectors.Count)
            {
                Vector3D result = vectors[i1] - vectors[i2];
                lblResult.Text = $"{vectors[i1]} - {vectors[i2]} = {result}";
            }
            else
            {
                MessageBox.Show("Неверный индекс вектора!");
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int i1 = (int)numIndex1.Value;
            int i2 = (int)numIndex2.Value;

            if (i1 < vectors.Count && i2 < vectors.Count)
            {
                double result = Vector3D.GetDotProduct(vectors[i1], vectors[i2]);
                lblResult.Text = $"{vectors[i1]} · {vectors[i2]} = {result:F4}";
            }
            else
            {
                MessageBox.Show("Неверный индекс вектора!");
            }
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            int i1 = (int)numIndex1.Value;

            if (i1 < vectors.Count)
            {
                double result = vectors[i1].GetLength();
                lblResult.Text = $"Длина вектора {vectors[i1]} = {result:F4}";
            }
            else
            {
                MessageBox.Show("Неверный индекс вектора!");
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            int i1 = (int)numIndex1.Value;
            int i2 = (int)numIndex2.Value;

            if (i1 < vectors.Count && i2 < vectors.Count)
            {
                double result = Vector3D.GetCosAngle(vectors[i1], vectors[i2]);
                lblResult.Text = $"cos(угла) между {vectors[i1]} и {vectors[i2]} = {result:F6}";
            }
            else
            {
                MessageBox.Show("Неверный индекс вектора!");
            }
        }

        private void UpdateList()
        {
            listBoxVectors.Items.Clear();
            for (int i = 0; i < vectors.Count; i++)
            {
                listBoxVectors.Items.Add($"[{i}] {vectors[i]}");
            }

            if (vectors.Count > 0)
            {
                numIndex1.Maximum = vectors.Count - 1;
                numIndex2.Maximum = vectors.Count - 1;
                numIndex1.Enabled = true;
                numIndex2.Enabled = true;
                btnSum.Enabled = true;
                btnSub.Enabled = true;
                btnDot.Enabled = true;
                btnLength.Enabled = true;
                btnCos.Enabled = true;
            }
            else
            {
                numIndex1.Enabled = false;
                numIndex2.Enabled = false;
                btnSum.Enabled = false;
                btnSub.Enabled = false;
                btnDot.Enabled = false;
                btnLength.Enabled = false;
                btnCos.Enabled = false;
            }
        }
    }
}
