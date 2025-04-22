using TaskTracker.Core.Entities;
namespace TaskTracker.Core.Interfaces
;

public interface ITaskRepository
{
    Task<List<TaskItem>> GetTasksAsync();
    Task<TaskItem> GetTaskAsync(int taskId);
    Task<TaskItem> AddTaskAsync(TaskItem task);
    Task<TaskItem> UpdateTaskAsync(TaskItem task);
    Task<TaskItem> DeleteTaskAsync(int taskId);
}
