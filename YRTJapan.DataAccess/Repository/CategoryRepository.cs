﻿using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.Core;

namespace YRTJapan.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
