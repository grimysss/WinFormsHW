using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
	public partial class MainForm : Form
	{
		private string _fileName;
		private string _path;
		private IEnumerable<string> _filesDirectory;

		public MainForm()
		{
			InitializeComponent();

			_cmbEnterMath.Items.Add("1");
			_cmbEnterMath.Items.AddRange(new string[] {"2", "3", "4" });
			_cmbEnterMath.Items.Insert(4, "5");

			_txtMath.Visible = true;
			_cmbEnterMath.Visible = true;

			_txtRus.Visible = false;
			_cmbEnterRus.Visible = false;

			_txtHistory.Visible = false;
			_cmbEnterHistory.Visible = false;

			_txtH20.Visible = false;
			_cmbEnterH20.Visible = false;

			_rdiKids.CheckedChanged += _rdiKids_CheckedChanged1;
			_rdiTeeneger.CheckedChanged += _rdiKids_CheckedChanged1;
			_rdiPeople.CheckedChanged += _rdiKids_CheckedChanged1;

			_openFileDialog.Filter = "Image|*.png; *.jpg|Video|*.avi; *.mp4";

			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();

			col1.Name = "Имя";
			col2.Name = "Фамилия";
			col3.Name = "Математика";
			col4.Name = "Русский язык";
			col5.Name = "История";
			col6.Name = "Химия";

			_dataGridView.Columns.Add(col1);
			_dataGridView.Columns.Add(col2);
			_dataGridView.Columns.Add(col3);
			_dataGridView.Columns.Add(col4);
			_dataGridView.Columns.Add(col5);
			_dataGridView.Columns.Add(col6);

		}

		private void _rdiKids_CheckedChanged1(object sender, EventArgs e)
		{
			if(_rdiKids.Checked == true)
			{
				_txtMath.Visible = true;
				_cmbEnterMath.Visible = true;

				_txtRus.Visible = true;
				_cmbEnterRus.Visible = true;

				_txtHistory.Visible = false;
				_cmbEnterHistory.Visible = false;

				_txtH20.Visible = false;
				_cmbEnterH20.Visible = false;
			}

			else if(_rdiTeeneger.Checked == true)
			{
				_txtMath.Visible = true;
				_cmbEnterMath.Visible = true;

				_txtRus.Visible = true;
				_cmbEnterRus.Visible = true;

				_txtHistory.Visible = true;
				_cmbEnterHistory.Visible = true;

				_txtH20.Visible = false;
				_cmbEnterH20.Visible = false;
			}

			else if(_rdiPeople.Checked == true)
			{
				_txtMath.Visible = true;
				_cmbEnterMath.Visible = true;

				_txtRus.Visible = true;
				_cmbEnterRus.Visible = true;

				_txtHistory.Visible = true;
				_cmbEnterHistory.Visible = true;

				_txtH20.Visible = true;
				_cmbEnterH20.Visible = true;
			}
		}

		/// <summary>Открытие файла.</summary>
		private void OpenFile(object sender, EventArgs e)
		{
			if(_openFileDialog.ShowDialog() == DialogResult.Cancel) return;

			_fileName = _openFileDialog.FileName;

			_txtFile.Text = _fileName;
		}

		/// <summary>Открытие директории.</summary>
		private void OpenDirectory(object sender, EventArgs e)
		{
			if(_folderBrowserDialog.ShowDialog() == DialogResult.Cancel) return;

			_path = _folderBrowserDialog.SelectedPath;

			_txtFile.Text = _path;

			_filesDirectory = Directory.EnumerateFiles(_path, "*.*", SearchOption.TopDirectoryOnly)
				.Where(s => s.EndsWith("*.png") || s.EndsWith("*.jpg"));
		}

		/// <summary>Создаем эвент нажатия на кнопку и его последствия.</summary>
		/// <param name="sender">Источник события.</param>
		/// <param name="e">Объект события.</param>
		private void _btnSave_Click(object sender, EventArgs e)
		{
			//Вводим переменную "countRows" для учета строк. Выводим имя и фамилию
			int countRows = _dataGridView.Rows.Add();
			_dataGridView[0,countRows].Value = _txtEnterName.Text;
			_dataGridView[1, countRows].Value = _txtEnterLastName.Text;

			//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
			if(_cmbEnterMath.SelectedIndex == -1)
			{
				_dataGridView[2, countRows].Value = " ";
			}

			//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
			else if(_cmbEnterMath.SelectedIndex >= 0)
			{
				_dataGridView[2, countRows].Value = _cmbEnterMath.SelectedItem.ToString();
			}

			//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
			if(_cmbEnterRus.SelectedIndex == -1)
			{
				_dataGridView[3, countRows].Value = " ";
			}

			//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
			else if(_cmbEnterRus.SelectedIndex >= 0)
			{
				_dataGridView[3, countRows].Value = _cmbEnterRus.SelectedItem.ToString();
			}

			//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
			if(_cmbEnterHistory.SelectedIndex == -1)
			{
				_dataGridView[4, countRows].Value = " ";
			}

			//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
			else if(_cmbEnterHistory.SelectedIndex >= 0)
			{
				_dataGridView[4, countRows].Value = _cmbEnterHistory.SelectedItem.ToString();
			}

			//Проверяем заполненные ли данные в комбобоксе, если нет, выводим пустую сетку
			if(_cmbEnterH20.SelectedIndex == -1)
			{
				_dataGridView[5, countRows].Value = " ";
			}

			//Проверяем заполненные ли данные в комбобоксе, если данные есть, то выводим из содержание в сетку
			else if(_cmbEnterH20.SelectedIndex >= 0)
			{
				_dataGridView[5, countRows].Value = _cmbEnterH20.SelectedItem.ToString();
			}

			//Выводим месседжбокс
			MessageBox.Show("Данные добавлены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		/// <summary>Создаем эвент вноса данных в текстбокст. И задаем исключения.</summary>
		/// <param name="sender">Источник события.</param>
		/// <param name="e">Объект события.</param>
		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Вводим ограничение на ввод только букв в текстбоксе "Имя", также разрешаем использовать бэкспейс и делит
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		/// <summary>Создаем эвент вноса данных в текстбокст. И задаем исключения.</summary>
		/// <param name="sender">Источник события.</param>
		/// <param name="e">Объект события.</param>
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
