using TaskTracker.Shared;
using System.Collections.Generic;
using System.Linq;

namespace TaskTracker.Server.Services;

public class TaskService
{
    private readonly List<TaskItem> _tasks = new();
    private int _nextId = 1;

    public List<TaskItem> GetAll() => _tasks;

    public TaskItem GetById(int id) => _tasks.FirstOrDefault(t => t.Id == id);

    public TaskItem Create(TaskItem task)
    {
        task.Id = _nextId++;
        _tasks.Add(task);
        return task;
    }

    public TaskItem Update(int id, TaskItem task)
    {
        var existing = GetById(id);
        if (existing == null) return null;
        
        existing.Title = task.Title;
        existing.IsCompleted = task.IsCompleted;
        return existing;
    }

    public bool Delete(int id)
    {
        var task = GetById(id);
        return task != null && _tasks.Remove(task);
    }
}