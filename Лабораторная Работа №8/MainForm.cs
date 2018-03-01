using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Лабораторная_Работа__8
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        string fileName = "Temperature.bin";
        public MainForm()
        {
            InitializeComponent();
            LoadFromFile();
        }
        /// <summary>
        /// Добавление в конец
        /// </summary>
        /// <param name="averageTemp"></param>
        private void AddToEndOfFile(AverageTemp averageTemp)
        {
            FileStream f1 = new FileStream(fileName, FileMode.OpenOrCreate);
            f1.Position = f1.Length;
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f1, averageTemp); // сохранение объекта  в потоке f
            f1.Close();
        }

        /// <summary>
        /// Добавление в начало
        /// </summary>
        private void AddToBeginOfFile(AverageTemp averageTemp)
        {
            FileStream temp = new FileStream("Temp.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(temp, averageTemp);

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            stream.Position = 0;
            while (stream.Position < stream.Length)
            {
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                if (!obj.Deleted)
                    bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
            }
            stream.Close();
            temp.Close();

            File.Delete(fileName);
            File.Move("Temp.bin", fileName);
            File.Delete("Temp.bin");

        }

        /// <summary>
        /// Добавление в заданную позицию
        /// </summary>
        private void AddToFileByIndex(AverageTemp averageTemp, int index)
        {
            FileStream temp = new FileStream("Temp.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            stream.Position = 0;
            int count = 0;
            while (stream.Position < stream.Length)
            {
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (count==index-1)
                    bf.Serialize(temp, averageTemp);

                if (!obj.Deleted)
                {
                    bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
                    count++;
                }
                
            }
            stream.Close();
            temp.Close();

            File.Delete(fileName);
            File.Move("Temp.bin", fileName);
            File.Delete("Temp.bin");
        }

        private void LoadFromFile()
        {
            try
            {
                listBox1.Items.Clear();

                FileStream f2 = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();

                while (f2.Position < f2.Length)
                {
                    AverageTemp d = (AverageTemp)bf.Deserialize(f2); // восстановление объекта
                    if (!d.Deleted)
                        listBox1.Items.Add(d);
                }
                f2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при открытии файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteFromFileByIndex(int indexForDelete)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            int count = 0;
            int index = 0;
            int deletedCount = 0;
            while (stream.Position < stream.Length)
            {
                long startPosition = stream.Position;
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (obj.Deleted)
                    deletedCount++;
                else
                {
                    if (index == indexForDelete)
                    {
                        obj.Deleted = true;
                        stream.Position = startPosition;
                        bf.Serialize(stream, obj); // сохранение объекта  в потоке f
                        deletedCount++;
                    }
                    index++;
                }

                count++;
            }

            if (deletedCount > count / 2)
            {
                FileStream temp = new FileStream("Temp.bin", FileMode.Create);
                stream.Position = 0;

                while (stream.Position < stream.Length)
                {
                    AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                    if (!obj.Deleted)
                        bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
                }
                temp.Close();
                stream.Close();

                File.Delete(fileName);
                File.Move("Temp.bin", fileName);
                File.Delete("Temp.bin");
            }

            stream.Close();
        }

        private void DeleteFromFileByKey(int key)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            int count = 0;
            int index = 0;
            int deletedCount = 0;
            while (stream.Position < stream.Length)
            {
                long startPosition = stream.Position;
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (obj.Deleted)
                    deletedCount++;
                else
                {
                    if (obj.NumDay == key)
                    {
                        obj.Deleted = true;
                        stream.Position = startPosition;
                        bf.Serialize(stream, obj); // сохранение объекта  в потоке f
                        deletedCount++;
                    }
                    index++;
                }

                count++;
            }

            if (deletedCount > count / 2)
            {
                FileStream temp = new FileStream("Temp.bin", FileMode.Create);
                stream.Position = 0;

                while (stream.Position < stream.Length)
                {
                    AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                    if (!obj.Deleted)
                        bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
                }
                temp.Close();
                stream.Close();

                File.Delete(fileName);
                File.Move("Temp.bin", fileName);
                File.Delete("Temp.bin");
            }
            else
                MessageBox.Show("Запись с указанным ключом не найдена.", "Редактирование по ключу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            stream.Close();
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void EditByIndex(int index)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            AverageTemp obj = null;
            int count = 0;
            long position = 0;

            while (stream.Position < stream.Length)
            {
                position = stream.Position;
                obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (listBox1.SelectedIndex == count)
                    break;

                count++;
            }

            EditForm editForm = new EditForm(obj);

            DialogResult dr = editForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                stream.Position = position;
                bf.Serialize(stream, editForm.AverageTemp); // сохранение объекта  в потоке
                listBox1.Items[index] = editForm.AverageTemp;
            }
            stream.Close();
        }


        private void EditByKey(int key)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            AverageTemp obj = null;
            int index = 0;
            long position = 0;

            while (stream.Position < stream.Length)
            {
                
                position = stream.Position;
                obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (obj.Deleted)
                    continue;

                if (obj.NumDay == key)
                    break;

                index++;
            }

            if (index < listBox1.Items.Count)
            {
                EditForm editForm = new EditForm(obj);

                DialogResult dr = editForm.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    stream.Position = position;
                    bf.Serialize(stream, editForm.AverageTemp); // сохранение объекта  в потоке
                    listBox1.Items[index] = editForm.AverageTemp;
                }
            }
            else
                MessageBox.Show("Запись с указанным ключом не найдена.","Редактирование по ключу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            stream.Close();
        }
        private void средняяТемператураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double average = GetAverageTemperature();

            MessageBox.Show(string.Format("Средняя температура: {0:0.00}", average));
        }

        private double GetAverageTemperature()
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            double average = 0, sum = 0;
            int count = 0;
            while (stream.Position < stream.Length)
            {
                AverageTemp d = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                sum = sum + d.Temperature;
                count++;
            }
            stream.Close();

            if (count != 0)
                average = sum / count;
            return average;
        }

        private void поискОтрезкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int distance = GetDistance();

            MessageBox.Show(string.Format("Отрезок: {0:0.00}", distance));
        }

        private int GetDistance()
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            int startDay = -1, finishDay = -1, count = 0;

            while (stream.Position < stream.Length)
            {
                AverageTemp readData = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (readData.Temperature < 0)
                {
                    if (startDay == -1)
                        startDay = count;

                    if (count >= startDay)
                        finishDay = count;
                }
                count++;
            }
            stream.Close();

            int distance = 0;
            if (finishDay > startDay)
                distance = finishDay - startDay - 1;
            return distance;
        }
        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(editForm.AverageTemp);
                AddToEndOfFile(editForm.AverageTemp);
            }
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Insert(0,editForm.AverageTemp);
                AddToBeginOfFile(editForm.AverageTemp);
            }
        }

        private void передТекущимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать элемент в списке.");
                return;
            }

            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex, editForm.AverageTemp);
                AddToFileByIndex(editForm.AverageTemp, listBox1.SelectedIndex);
            }
        }


        private void выбранныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            DeleteFromFileByIndex(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void удалитьПоКлючуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputKeyForm editForm = new InputKeyForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                DeleteFromFileByKey(editForm.Key);
                LoadFromFile();
            }
        }
        private void изменитьВыбранныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            EditByIndex(listBox1.SelectedIndex);
        }

        private void изменитьПоКлючуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputKeyForm editForm = new InputKeyForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                EditByKey(editForm.Key);
                LoadFromFile();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "bin";
            openFileDialog.Filter = "*.bin|*.bin";
            openFileDialog.FileName = fileName;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadFromFile();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = fileName;
            openFileDialog.Filter = "*.bin|*.bin";
            openFileDialog.CheckFileExists = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadFromFile();
            }
        }

        private void правкаToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            bool isNotListEmpty = listBox1.Items.Count != 0;
            изменитьToolStripMenuItem.Enabled = isNotListEmpty;
            удалитьToolStripMenuItem.Enabled = isNotListEmpty;
        }
    }
}
