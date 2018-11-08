﻿using Integration_Project.Data;
using Integration_Project.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integration_Project.ViewComponents
{
    public class EventsAroundMe : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public EventsAroundMe(ApplicationDbContext context)
        {
            _db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int maxEvents, bool includePrivate)
        {
            var items = await GetEventsAsync(maxEvents, includePrivate);
            return View("/Views/Shared/Components/EventList/Default.cshtml", items);
        }
        private async Task<List<EventViewModel>> GetEventsAsync(int maxEvents, bool includePrivate)
        {
            string userId = User.Identity.GetUserId();
            var standardUser = _db.StandardUsers.Where(u => u.ApplicationUserId.Equals(userId)).FirstOrDefault();
            int standardUserZipcode = standardUser.ZipCode;
            var eventsAroundMe = _db.Events.Where(e => e.Venues.Zipcode == standardUserZipcode).Take(maxEvents);
            eventsAroundMe = (includePrivate) ? eventsAroundMe : eventsAroundMe.Where(e => e.IsPrivate == false);
            List<EventViewModel> resultsViewModels = new List<EventViewModel>();
            foreach (Event e in eventsAroundMe)
            {
                resultsViewModels.Add(new EventViewModel { Event = e });
            }

            return resultsViewModels;
        }
    }
}
