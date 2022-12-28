﻿using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FileServices
{
    public class FileDownloadService : IFileDownloadService
    {

        Task<byte[]> IFileDownloadService.DownloadMovieFromLocation(string downloadPath)
        {
            return File.ReadAllBytesAsync(downloadPath);
        }
    }
}
