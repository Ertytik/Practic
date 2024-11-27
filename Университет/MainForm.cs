
using System.Data;
using System.Data.SQLite;

namespace Сельскохозяйственные_работы
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SQLiteConnection DB = new SQLiteConnection("DataSource=абра.db");

        string q1 = "SELECT Teacher.id_teacher,Teacher.ФИО, Audience.[Дата] FROM Audience\r\nINNER join Teacher on Audience.id_teacher = Teacher.id_teacher\r\nWHERE [Дата] BETWEEN '2001-03-01' and '2001-03-30' \r\nAND Audience.[Время] = 0;";
        string q2 = "SELECT \r\n    c1.id_audience,\r\n    c1.[Дата],\r\n    c1.[Время] AS [Начальное время],\r\n    c2.[Время] AS [Конфликтное время],\r\n    c1.[Группа] AS [Группа1],\r\n    c2.[Группа] AS [Группа2]\r\nFROM \r\n    Audience c1\r\ninner JOIN \r\n    Audience c2 ON  \r\n                 c1.[Дата] = c2.[Дата] \r\n                 AND c1.[Время] < c2.[Время]\r\nWHERE \r\n    (c1.[Время] + (SELECT [Кол-во часов] FROM Discipline WHERE id_discipline = c1.id_discipline)) > c2.[Время];";
        string q3 = "SELECT * FROM Audience\r\nwhere [Группа] = 'АП-17а' \r\nand [Дата] BETWEEN '2001-03-01' AND '2001-03-31';";
        string q4 = "SELECT \r\n    c.[Группа],\r\n    s.[Раздел предмета],\r\n    COUNT(s.id_discipline) * 100.0 / (SELECT COUNT(*) FROM Audience WHERE [Группа]= c.[Группа]) AS [ПРОЦЕНТЫ]\r\nFROM \r\n    Audience c\r\nJOIN \r\n    Discipline s ON c.id_discipline = s.id_discipline\r\nGROUP BY \r\n    c.[Группа], s.[Раздел предмета];";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataGridViewOnDBBrowser();
        }

        private void LoadDataGridViewOnDBBrowser()
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        #region Запросы
        private void Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q1, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void Query2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q2, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void Query3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q3, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void Query4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q4, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }
        #endregion

        #region Таблицы
        private void ProductsQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Audience", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }



        private void SalesQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Enterprise_Products", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void EmployeesQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Teacher", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void SuppliesQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Discipline", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void CompanyQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Department", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }
        #endregion     
    }
}
