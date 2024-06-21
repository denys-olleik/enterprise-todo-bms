using EnterpriseToDo.Business;
using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
    public class UserTaskService
    {
        public async Task<UserToDo> CreateAsync(UserToDo userTask)
        {
            FactoryManager factoryManager = new FactoryManager();
            return await factoryManager.GetUserTaskManager().CreateAsync(userTask);
        }

        public async Task<List<User>> GetUsers(int taskId, int organizationId)
        {
            FactoryManager factoryManager = new FactoryManager();
            return await factoryManager.GetUserTaskManager().GetUsersAsync(taskId, organizationId);
        }
    }
}