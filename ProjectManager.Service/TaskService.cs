using ProjectManager.Repo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static ProjectManager.Service.TaskService;

namespace ProjectManager.Service
{
    public class TaskService : ITaskService
    {
        private IRepository<ProjectManager.Data.Task> taskRepository;


        public TaskService(IRepository<ProjectManager.Data.Task> taskRepository)
        {
            this.taskRepository = taskRepository;

        }

        public IEnumerable<ProjectManager.Data.Task> GetTasks()
        {
            return taskRepository.GetAll();
        }

        public ProjectManager.Data.Task GetTask(string id)
        {
            return taskRepository.Get(id);
        }

        public void InsertTask(ProjectManager.Data.Task task)
        {
            taskRepository.Insert(task);
        }
        public void UpdateTask(ProjectManager.Data.Task task)
        {
            taskRepository.Update(task);
        }

        public void DeleteTask(string id)
        {

            var task = taskRepository.Get(id);
            if (task != null)
            {
                taskRepository.Delete(task);
                taskRepository.SaveChanges();
            }

        }
        public interface ITaskService
        {
            IEnumerable<ProjectManager.Data.Task> GetTasks();
            ProjectManager.Data.Task GetTask(string id);
            void InsertTask(ProjectManager.Data.Task task);
            void UpdateTask(ProjectManager.Data.Task task);
            void DeleteTask(string id);
        }
    }
}
