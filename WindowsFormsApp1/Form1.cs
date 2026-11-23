using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. ПРОВЕРКА НА НАЛИЧИЕ ДАННЫХ
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Пожалуйста, введите количество строк и столбцов!",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Прерываем выполнение, если поля пустые
            }

            // 2. ПРОВЕРКА НА КОРРЕКТНОСТЬ ВВОДА (должны быть целые числа)
            int rows, cols;
            bool isRowsValid = int.TryParse(textBox1.Text, out rows);
            bool isColsValid = int.TryParse(textBox2.Text, out cols);

            if (!isRowsValid || !isColsValid)
            {
                MessageBox.Show("Необходимо ввести целые числа!",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. ПРОВЕРКА НА ПОЛОЖИТЕЛЬНЫЕ ЗНАЧЕНИЯ (матрица не может иметь 0 или минус строк/столбцов)
            if (rows <= 0 || cols <= 0)
            {
                MessageBox.Show("Размерность матрицы должна быть больше нуля!",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. ОЧИСТКА ТАБЛИЦЫ ПЕРЕД НОВЫМ ЗАПОЛНЕНИЕМ
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 5. СОЗДАНИЕ СТОЛБЦОВ В DataGridView
            for (int j = 0; j < cols; j++)
            {
                dataGridView1.Columns.Add($"Column{j}", $"Столбец {j + 1}");
            }

            // 6. ГЕНЕРАЦИЯ МАТРИЦЫ И ЗАПОЛНЕНИЕ ЯЧЕЕК
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                // Добавляем новую строку в таблицу
                int rowIndex = dataGridView1.Rows.Add();

                for (int j = 0; j < cols; j++)
                {
                    // Генерируем случайное число от -99 до 99 и записываем в ячейку
                    int randomValue = random.Next(-99, 100);
                    dataGridView1.Rows[rowIndex].Cells[j].Value = randomValue;
                }
            }

        }
    }
}
