﻿using YRTJapan.Core;

namespace YRTJapan.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
