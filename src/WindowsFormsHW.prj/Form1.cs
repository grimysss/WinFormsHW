using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test__wf1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			//Выключаем неактивные комбобоксы
			InitializeComponent();
			_txtCompetenceLevel1.Enabled = false;
			_cmbEnterCompetenceLevel1.Enabled = false;
			_txtCompetenceLevel2.Enabled = false;
			_cmbEnterCompetenceLevel2.Enabled = false;
			_txtCompetenceLevel3.Enabled = false;
			_cmbEnterCompetenceLevel3.Enabled = false;

			//Создаем 7 колонок
			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();

			//Нахываем колонки
			col1.Name = "Имя";
			col2.Name = "Фамилия";
			col3.Name = "Пол";
			col4.Name = "Навык управления персоналом";
			col5.Name = "Навык работы в команде";
			col6.Name = "Навык работы в стрессовой ситуации";
			col7.Name = "Должность";

			//Добавляем колонки в сетку данных
			dataGridView.Columns.Add(col1);
			dataGridView.Columns.Add(col2);
			dataGridView.Columns.Add(col3);
			dataGridView.Columns.Add(col4);
			dataGridView.Columns.Add(col5);
			dataGridView.Columns.Add(col6);
			dataGridView.Columns.Add(col7);

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void _txtCompetenceLevel2_Click(object sender, EventArgs e)
		{

		}

		private void _txtCompetenceLevel1_Click(object sender, EventArgs e)
		{

		}

		private void _txtCompetence3_Click(object sender, EventArgs e)
		{

		}

		private void _grpMain_Enter(object sender, EventArgs e)
		{

		}

		private void _chkCompetence1_CheckedChanged(object sender, EventArgs e)
		{
			//Удаляем данные, если они уже внесены в комбобокс
			_cmbEnterCompetenceLevel1.SelectedIndex = -1;

			//Активируем комбобокс и текст, если галочка стоит
			if(_chkCompetence1.Checked == true)
			{
				_txtCompetenceLevel1.Enabled = true;
				_cmbEnterCompetenceLevel1.Enabled = true;
			}

			//Деактивиуем комбобокс и текст, если галочка убрана
			else if(_chkCompetence1.Checked == false)
			{
				_txtCompetenceLevel1.Enabled = false;
				_cmbEnterCompetenceLevel1.Enabled = false;
			}
		}

		private void _chkCompetence2_CheckedChanged(object sender, EventArgs e)
		{
			//Удаляем данные, если они уже внесены в комбобокс
			_cmbEnterCompetenceLevel2.SelectedIndex = -1;

			//Активируем комбобокс и текст, если галочка стоит
			if(_chkCompetence2.Checked == true)
			{
				_txtCompetenceLevel2.Enabled = true;
				_cmbEnterCompetenceLevel2.Enabled = true;
			}

			//Деактивиуем комбобокс и текст, если галочка убрана
			else if(_chkCompetence2.Checked == false)
			{
				_txtCompetenceLevel2.Enabled = false;
				_cmbEnterCompetenceLevel2.Enabled = false;
			}
		}

		private void _chkCompetence3_CheckedChanged(object sender, EventArgs e)
		{
			//Удаляем данные, если они уже внесены в комбобокс
			_cmbEnterCompetenceLevel3.SelectedIndex = -1;

			//Активируем комбобокс и текст, если галочка стоит
			if(_chkCompetence3.Checked == true)
			{
				_txtCompetenceLevel3.Enabled = true;
				_cmbEnterCompetenceLevel3.Enabled = true;
			}

			//Деактивиуем комбобокс и текст, если галочка убрана
			else if(_chkCompetence3.Checked == false)
			{
				_txtCompetenceLevel3.Enabled = false;
				_cmbEnterCompetenceLevel3.Enabled = false;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			//Выводим месседжбокс с 2 варинтами ответа
			DialogResult dr = MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			//При ответе "ОК" начинаем выводить данные в сетку
			if(dr == DialogResult.OK)
			{
				//Выводим имя и фамилию
				int n = dataGridView.Rows.Add();
				dataGridView[0, n].Value = _txtEnterName.Text;
				dataGridView[1, n].Value = _txtEnterLastName.Text;

				//Проверяем какой пол выбран
				if(_rdiGender1.Checked)
				{
					dataGridView[2, n].Value = _rdiGender1.Text;
				}

				else if(_rdiGender2.Checked)
				{
					dataGridView[2, n].Value = _rdiGender2.Text;
				}

				//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
				if(_cmbEnterCompetenceLevel1.SelectedIndex == -1)
				{
					dataGridView[3, n].Value = " ";
				}

				//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
				else if(_cmbEnterCompetenceLevel1.SelectedIndex >= 0)
				{
					dataGridView[3, n].Value = _cmbEnterCompetenceLevel1.SelectedItem.ToString();
				}

				//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
				if(_cmbEnterCompetenceLevel2.SelectedIndex == -1)
				{
					dataGridView[4, n].Value = " ";
				}

				//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
				else if(_cmbEnterCompetenceLevel2.SelectedIndex >= 0)
				{
					dataGridView[4, n].Value = _cmbEnterCompetenceLevel2.SelectedItem.ToString();
				}

				//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
				if(_cmbEnterCompetenceLevel3.SelectedIndex == -1)
				{
					dataGridView[5, n].Value = " ";
				}

				//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
				else if(_cmbEnterCompetenceLevel3.SelectedIndex >= 0)
				{
					dataGridView[5, n].Value = _cmbEnterCompetenceLevel3.SelectedItem.ToString();
				}

				//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
				if(_cmbEnterPosition.SelectedIndex == -1)
				{
					dataGridView[6, n].Value = " ";
				}

				//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
				else if(_cmbEnterPosition.SelectedIndex >= 0)
				{
					dataGridView[6, n].Value = _cmbEnterPosition.SelectedItem.ToString();
				}
			}
		}

		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Вводим ограничение на ввод только букв в текстбоксе "Имя", также разрешаем использовать бэкспейс и делит
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		private void _txtEnterLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Вводим ограничение на ввод только букв в текстбоксе "Фамилия", также разрешаем использовать бэкспейс и делит
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}
	}
}
