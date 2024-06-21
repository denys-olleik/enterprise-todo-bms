﻿using EnterpriseToDo.Business;
using EnterpriseToDo.CustomAttributes;
using EnterpriseToDo.Models.LocationViewModels;
using EnterpriseToDo.Service;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseToDo.Controllers
{
  [AuthorizeWithOrganizationId]
  [ApiController]
  [Route("api/l")]
  public class LocationApiController : BaseController
  {
    private readonly LocationService _locationService;

    public LocationApiController(LocationService locationService)
    {
      _locationService = locationService;
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAllLocations()
    {
      var organizationId = GetOrganizationId();
      List<Location> locations = await _locationService.GetAllHierarchicalAsync(organizationId);

      List<LocationViewModel> locationsViewmodel = locations
          .Where(location => location.ParentLocationId == null)
          .Select(ConvertToViewModel)
          .ToList();

      return Ok(locationsViewmodel);
    }

    private LocationViewModel ConvertToViewModel(Location location)
    {
      var viewModel = new LocationViewModel
      {
        LocationID = location.LocationID,
        Name = location.Name,
        Created = location.Created,
        ParentLocationId = location.ParentLocationId,
        CreatedById = location.CreatedById,
        Children = new List<LocationViewModel>()
      };

      if (location.Children != null)
      {
        foreach (var child in location.Children)
        {
          viewModel.Children.Add(ConvertToViewModel(child));
        }
      }

      return viewModel;
    }
  }
}