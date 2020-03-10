using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.Data
{
    public class Database
    {
        SQLiteAsyncConnection _dbContext;

        public Database(string dbPath)
        {
            _dbContext = new SQLiteAsyncConnection(dbPath);
            _dbContext.CreateTableAsync<ImageInfo>().Wait();
        }

        public async Task<List<ImageInfo>> GetImageInfosAsync()
        {
            return await _dbContext.Table<ImageInfo>().ToListAsync();
        }

        public async Task<ImageInfo> GetImageInfoAsync(int id)
        {
            return await _dbContext.Table<ImageInfo>()
                           .Where(x => x.Id == id)
                           .FirstOrDefaultAsync();
        }

        public async Task<int> SaveImageInfoAsync(ImageInfo ImageInfo)
        {
            if (ImageInfo.Id != 0)
            {
                return await _dbContext.UpdateAsync(ImageInfo);
            }
            else
            {
                return await _dbContext.InsertAsync(ImageInfo);
            }
        }

        public async Task<int> DeleteImageInfoAsync(ImageInfo ImageInfo)
        {
            return await _dbContext.DeleteAsync(ImageInfo);
        }
    }
}
