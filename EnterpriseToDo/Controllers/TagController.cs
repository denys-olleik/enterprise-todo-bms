using EnterpriseToDo.Business;
using EnterpriseToDo.CustomAttributes;
using EnterpriseToDo.Models.TagViewModels;
using EnterpriseToDo.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseToDo.Controllers
{
    [AuthorizeWithOrganizationId]
    [Route("tag")]
    public class TagController : BaseController
    {
        [HttpGet]
        [Route("tags")]
        public async Task<IActionResult> Tags()
        {
            TagsViewModel tagsViewModel = new TagsViewModel();

            TagService tagService = new TagService();
            List<Tag> tags = await tagService.GetAllAsync();

            tagsViewModel.Tags = tags.Select(tag => new TagViewModel
            {
                ID = tag.TagID,
                Name = tag.Name
            }).ToList();

            return View(tagsViewModel);
        }
    }
}