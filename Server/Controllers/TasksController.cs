using Microsoft.AspNetCore.Mvc;
using TaskTracker.Server.Services;
using TaskTracker.Shared;
using System.Collections.Generic;

namespace TaskTracker.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly TaskService _taskService;

    public TasksController(TaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public ActionResult<List<TaskItem>> GetTasks() => _taskService.GetAll();

    [HttpPost]
    public ActionResult<TaskItem> CreateTask(TaskItem task) => _taskService.Create(task);

    [HttpPut("{id}")]
    public ActionResult<TaskItem> UpdateTask(int id, TaskItem task)
    {
        var updated = _taskService.Update(id, task);
        return updated == null ? NotFound() : updated;
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteTask(int id)
    {
        return _taskService.Delete(id) ? NoContent() : NotFound();
    }
}