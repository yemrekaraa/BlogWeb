using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents.Default
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Emre"
                },
                new UserComment
                {
                    ID = 2,
                    UserName="Ebru"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Tarık"
                }
            };
            return View(commentvalues);
        }
    }
}
