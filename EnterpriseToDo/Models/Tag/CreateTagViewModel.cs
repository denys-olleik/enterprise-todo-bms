using EnterpriseToDo.Models.TaskStatusViewModels;
using FluentValidation.Results;

namespace EnterpriseToDo.Models.TagViewModels
{
    public class CreateTagViewModel
    {
        public string Name { get; set; }
        public string Action { get; set; }
        public string Metadata { get; set; }
        public List<string> MatchTypes { get; set; }
        public string SelectedMatchType { get; set; }

        public string StatusChangeSequenceIds { get; set; }

        public List<TaskStatusViewModel> Statuses { get; set; }

        public ValidationResult ValidationResult { get; set; }
    }
}