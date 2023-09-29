using QLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFacultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFacultys);
                //dgvStudent.DataSource=listStudent;
                BindGrid(listStudent);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void  FillFalcultyCombobox (List<Faculty> listFaculty)
        {
            this.cmbFalculty.DataSource = listFaculty;
            this.cmbFalculty.DisplayMember = "FacultyName";
            this.cmbFalculty.ValueMember = "FacultyID";

        }
        private void BindGrid (List<Student> listStudent) 
        {
            dgvStudent.Rows.Clear();
            foreach (var item  in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if (CheckDataInput)
            {
                if (CheckIDSinhVien(txtMSSV.Text) == -1)
                {
                    Student newStudent = new Student();
                    newStudent.StudentID = txtMSSV.Text;
                    newStudent.FullName = txtHoTen.Text;
                    newStudent.AverageScore = Convert.ToDouble(txtDTB.Text);
                    newStudent.FacultyID = Convert.ToInt32(cmbFalculty.SelectedValue.ToString());

                   context.Students.AddOrUpdate(newStudent)
                   context.SaveChange();


                    loadDGV();
                    loadForm();
                    MessageBox.Show("Them sinh vien thanh cong");
                }
                else
                {
                    MessageBox.Show("Sinh vien da ton tai");

                }

                }
            }

        private void loadForm()
        {
           txtMSSV.Clear(); 
           txtHoTen.Clear();
           txtDTB.Clear();

        }

        private void loadDGV()
        {
            List<Student> newListStudent = Context.Students.ToList();
            FillDataDGV(newListStudent);
        }

        private void FillDataDGV(List<Student> newListStudent)
        {
            throw new NotImplementedException();
        }

        private int CheckIDSinhVien(string idNewStudent)
        {
            int length = dgvStudent.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value!=null)
                    if (dgvStudent.Rows[i].Cells[0].Value.ToString() == idNewStudent)
                    {
                        return i;
                    }
                return -1;
            }
        }

        private bool CheckDataInput() 
        {
            if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDTB.Text == "")
                throw new Exception("Ban hay nhap day du tong tin");
            else if (txtMSSV.TextLength != 10)
            {
                MessageBox.Show("MSSV cua ban chua dung");
                return false;
            }
            else
            {
                float kq = 0;
                bool KetQua = float.TryParse(txtDTB.Text, out kq);
                if (!KetQua)
                {
                    MessageBox.Show("Diem sinh vien chua dung");
                    return false;
                }

            }

            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckDataInput())
            {
                Student updateStudent = Context.Students.FirsOrDefault(p => p.StudentID == txtMSSV.Text);
                if (updateStudent != null)
                {
                    Context.Students.AddOrUpdate(updateStudent);
                    updateStudent.FullName= txtHoTen.Text;
                    updateStudent.AverageScore = Convert.ToInt32(txtDTB.Text);
                    updateStudent.FacultyID = Convert.ToInt32(cmbFalculty.SelectedValue.ToString());
                    Context.SaveChanges();
                    ReloadDGV();
                    ReloadForm();
                    MessageBox.Show("Chinh sua thong tin thanh cong");
                }
            }
        }

        private void ReloadForm()
        {
            ;
        }

        private void ReloadDGV()
        {
           
        }
    }

    
}



