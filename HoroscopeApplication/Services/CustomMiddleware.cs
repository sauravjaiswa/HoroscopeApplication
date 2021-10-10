﻿using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ISunsignRepository _sunsignRepository;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
            //_sunsignRepository = sunsignRepository;
        }

        public async Task Invoke(HttpContext httpContext, ISunsignRepository sunsignRepository)
        {
            await sunsignRepository.MapDates();

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
