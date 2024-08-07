﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;
using MyApp.Web.Filter;

namespace MyApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : BaseController<Blog>
    {
        public BlogController(BloggingContext context, ILogger<Blog> logger) : base(context, logger)
        {
        }
    }
}
