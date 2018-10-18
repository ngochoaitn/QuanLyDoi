using System.Threading.Tasks;

namespace QuanLyDoi.Support
{
    class SequenceId
    {
        static Database.QuanLyDoiModel _dbStatic;
        static SequenceId()
        {
            _dbStatic = new Database.QuanLyDoiModel();
        }

        public static async Task<int> GetNextSequenceAsync(string seq_name)
        {
            var rawQuery = _dbStatic.Database.SqlQuery<int>($"SELECT NEXT VALUE FOR {seq_name};");
            return await rawQuery.SingleAsync();
        }

        public static async Task<int> GIAY_DI_DUONG()
        {
            return await GetNextSequenceAsync("SEQ_GIAY_DI_DUONG");
        }

        public static async Task<int> CONG_VAN()
        {
            return await GetNextSequenceAsync("SEQ_CONG_VAN");
        }
    }
}
