using QuanLyDoi.Forms.GiayDiDuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace QuanLyDoi.Database.LocalData
{
    [Serializable]
    public class DatabaseManager
    {
        private string _fileDataPath;

        public static event Action<DatabaseManager> DataChanged;
        public Dictionary<string, string> ListSettings { set; get; }
        public BindingList<ChonDiaBanXa> ChonDiaBanXas { get; set; }

        public DatabaseManager(string file = "Data\\data.qld")
        {
            _fileDataPath = file;
            this.CreateIfNotExist();
            this.Load();
        }

        public bool Exits()
        {
            return File.Exists(_fileDataPath);
        }

        public void CreateDatabbase()
        {
            this.ListSettings = new Dictionary<string, string>();
            this.ChonDiaBanXas = new BindingList<ChonDiaBanXa>();
            this.SaveChange();
        }

        public void CreateIfNotExist()
        {
            if (!this.Exits())
                this.CreateDatabbase();
        }

        private void Load()
        {
            FileStream fs = new FileStream(_fileDataPath, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                DatabaseManager tmp = (DatabaseManager)bf.Deserialize(fs);
                fs.Close();

                this.ListSettings = tmp.ListSettings ?? new Dictionary<string, string>();
                this.ChonDiaBanXas = tmp.ChonDiaBanXas ?? new BindingList<ChonDiaBanXa>();
            }
            catch
            {
                fs.Close();
                this.CreateDatabbase();
            }
        }

        public bool SaveChange(string file_path=null)
        {
            _fileDataPath = file_path ?? _fileDataPath;
            FileInfo f = new FileInfo(_fileDataPath);

            if (!f.Directory.Exists)
                f.Directory.Create();

            FileStream fs = new FileStream(_fileDataPath, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, this);

                fs.Close();

                if (DataChanged != null)
                    DataChanged(this);

                return true;
            }
            catch(Exception ex)
            {
                fs.Close();
                return false;
            }
        }

        public Task<bool> SaveChangeAsync(string file_path = null)
        {
            return Task.Run<bool>(() => { return this.SaveChange(file_path); });
        }
    }
}
