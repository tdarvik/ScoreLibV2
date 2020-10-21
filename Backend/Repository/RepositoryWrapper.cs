using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper, IDisposable
    {
        private readonly RepositoryContext _context;
        private IScoreRepository _scoreRepository;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _context = repositoryContext;
        }

        public IScoreRepository Score
        {
            get
            {
                if (_scoreRepository == null)
                {
                    _scoreRepository = new ScoreRepository(_context);
                }
                return _scoreRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
