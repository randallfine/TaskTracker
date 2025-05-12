using Microsoft.EntityFrameworkCore;
using TaskTracker.Core.Entities;
using TaskTracker.Core.Interfaces;
using TaskTracker.Infrastructure.Data;

namespace TaskTracker.Infrastructure.Repositories
{
    public class TaskReposiory : ITaskRepository
    {
        private readonly AppDbContext _context;
        public TaskReposiory(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<TaskItem>> GetTasksAsync()
        {
            return await _context.TaskItems.ToListAsync();
        }
        public async Task<TaskItem?> GetTaskByIdAsync(int taskId)
        {
            return await _context.TaskItems.FindAsync(taskId);
        }
        public async Task<TaskItem> AddTaskAsync(TaskItem task)
        {
            _context.TaskItems.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }
        public async Task<TaskItem> UpdateTaskAsync(TaskItem task)
        {
            _context.TaskItems.Update(task);
            await _context.SaveChangesAsync();
            return task;
        }
        public async Task<TaskItem?> DeleteTaskAsync(int taskId)
        {
            var task = await GetTaskByIdAsync(taskId);
            if (task != null)
            {
                _context.TaskItems.Remove(task);
                await _context.SaveChangesAsync();
            }
            return task;
        }
    }
}
