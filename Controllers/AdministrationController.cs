﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VioRentals.ViewModels;

namespace VioRentals.Controllers;

[Authorize(Roles = "Admin")]
public class AdministrationController : Controller
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AdministrationController(RoleManager<IdentityRole> roleManager,
        UserManager<IdentityUser> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }

    [HttpGet]
    //[Authorize(Roles = "Admin")]
    public IActionResult CreateRole()
    {
        var model = new CreateRoleViewModel();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
    {
        if (ModelState.IsValid)
        {
            var identityRole = new IdentityRole
            {
                Name = model.RoleName
            };

            var result = _roleManager.CreateAsync(identityRole).Result;

            if (result.Succeeded) return RedirectToAction("ListRoles", "Administration");

            foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);
        }

        return View(model);
    }

    [HttpGet]
    public IActionResult ListRoles()
    {
        var roles = _roleManager.Roles;
        return View(roles);
    }

    [HttpGet]
    public async Task<IActionResult> EditRole(string id)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
            return View("NotFound");
        }

        var model = new EditRoleViewModel
        {
            Id = role.Id,
            RoleName = role.Name
        };
        var users = _userManager.Users.ToList();
        foreach (var user in users)
            if (await _userManager.IsInRoleAsync(user, role.Name))
                model.Users.Add(user.UserName);


        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> EditRole(EditRoleViewModel model)
    {
        var role = await _roleManager.FindByIdAsync(model.Id);
        if (role == null)
        {
            ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
            return View("NotFound");
        }

        role.Name = model.RoleName;
        var result = await _roleManager.UpdateAsync(role);

        if (result.Succeeded) return RedirectToAction("ListRoles");

        foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> EditUsersInRole(string roleId)
    {
        ViewBag.roleId = roleId;

        var role = await _roleManager.FindByIdAsync(roleId);

        if (role == null)
        {
            ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
            return View("NotFound");
        }

        var model = new List<UserRoleViewModel>();
        var users = _userManager.Users.ToList();
        foreach (var user in users)
        {
            var userRoleViewModel = new UserRoleViewModel
            {
                UserId = user.Id,
                UserName = user.UserName
            };

            if (await _userManager.IsInRoleAsync(user, role.Name))
                userRoleViewModel.IsSelected = true;
            else
                userRoleViewModel.IsSelected = false;

            model.Add(userRoleViewModel);
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
    {
        var role = await _roleManager.FindByIdAsync(roleId);

        if (role == null)
        {
            ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
            return View("NotFound");
        }

        if (!ModelState.IsValid) return View(model);


        for (var i = 0; i < model.Count; i++)
        {
            var user = await _userManager.FindByIdAsync(model[i].UserId);

            if (user != null)
            {
                IdentityResult result = null;

                if (model[i].IsSelected && !await _userManager.IsInRoleAsync(user, role.Name))
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                else
                    continue;

                if (result == null || !result.Succeeded)
                {
                    ModelState.AddModelError("", "Cannot add or remove user to/from role");
                    return View(model);
                }
            }
        }

        return RedirectToAction("EditRole", new { Id = roleId });
    }

    //delete role
    [HttpGet]
    public async Task<IActionResult> DeleteRole(string id)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
            return View("NotFound");
        }

        var result = await _roleManager.DeleteAsync(role);

        if (result.Succeeded) return RedirectToAction("ListRoles");

        foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);

        return View("ListRoles");
    }
}