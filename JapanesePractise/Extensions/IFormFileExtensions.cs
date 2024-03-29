﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapanesePractise.Extensions
{
    public static class IFormFileExtensions
    {
        public static async Task<string> ReadAsStringAsync(this IFormFile file)
        {
            var result = new StringBuilder();
            using (var stream = file.OpenReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    while (reader.Peek() >= 0)
                        result.AppendLine(await reader.ReadLineAsync());
                }
            }

            return result.ToString();
        }
    }
}
