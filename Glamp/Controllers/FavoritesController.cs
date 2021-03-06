﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Glamp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Glamp.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly IFavoritesRepository repo;

        public FavoritesController(IFavoritesRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
           var user = User.Identity.Name;
           var favorites = repo.GetAllFavorites(user);

            return View(favorites);
        }

        public IActionResult InsertFavoriteToDatabase(string facilityID, string facility, string user, string contractID)
        {

            repo.InsertFavorite(facilityID, facility, user, contractID);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteFavorite(Favorites favorite)
        {
            repo.DeleteFavorite(favorite);

            return RedirectToAction("Index");
        }



    }
}
