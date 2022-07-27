using Microsoft.EntityFrameworkCore;
using xAI.Data;
using System;
using TestProject.Infrastructure;

namespace xAI.Tests.Infrastructure
{
    public class xAITestBase : IDisposable
    {
        protected readonly xAIContext _context;

        public xAITestBase()
        {
            var options = new DbContextOptionsBuilder<xAIContext>()
                .EnableSensitiveDataLogging()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new xAIContext(options);

            _context.Database.EnsureCreated();

            xAIInitializer.Initialize(_context);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();

            _context.Dispose();
        }
    }
}