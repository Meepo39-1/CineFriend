using Application.Services;
using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage;
using static System.Net.WebRequestMethods;

namespace Infrastructure.FileServices
{

    public class BlobStorageService : IBlobStorageService
    {
        const string blobMovieContainerName = "movies";
        const string accountName = "movieroom";
        const string accountKey = "gk3Xr+lb3+OcZ6KnK8vskK5WCrbFWSvxZgH0DrA8dm1Sbb4fsQV0UUqPJkcqkmNvDbf51HQ7VUdY+AStrL/6Qg==";
        const string connectionString = "DefaultEndpointsProtocol=https;AccountName=movieroom;AccountKey=gk3Xr+lb3+OcZ6KnK8vskK5WCrbFWSvxZgH0DrA8dm1Sbb4fsQV0UUqPJkcqkmNvDbf51HQ7VUdY+AStrL/6Qg==;EndpointSuffix=core.windows.net";
    //const string auxiliarFile = "aux.bin";
        //nu inteleg de ce am nevoie de o referinta
        public static BlobServiceClient GetBlobServiceClient(
        string accountName, string accountKey)
        {
            Azure.Storage.StorageSharedKeyCredential sharedKeyCredential =
                new StorageSharedKeyCredential(accountName, accountKey);

            string blobUri = "https://" + accountName + ".blob.core.windows.net";

            return new BlobServiceClient
                (new Uri(blobUri), sharedKeyCredential);
        }

    
        public async Task<string> UploadMovieToCloud(byte[] movieData, Movie movieModel)
        {
            
            var containerClient = GetBlobServiceClient(accountName, accountKey).GetBlobContainerClient(blobMovieContainerName);

            BinaryData binaryData = new BinaryData(movieData);

            var response = await containerClient.UploadBlobAsync(movieModel.Id.ToString(), binaryData);
           

            //BlobUploadOptions
            //blobClient.UploadAsync()

            return $"https://{accountName}. blob.core.windows.net./{blobMovieContainerName}" + movieModel.Id.ToString();
         
        }
     

        public Task<string> UploadMovieToCloud(Movie movie)
        {
            throw new NotImplementedException();
        }
        
       
        public  async Task<byte[]> DownloadMovie(Movie movie)
        {
            BlobServiceClient blobServiceClient = GetBlobServiceClient(accountName, accountKey);
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(blobMovieContainerName);
            BlobClient blobClient = blobContainerClient.GetBlobClient(movie.Id.ToString());

            var memoryStream = new MemoryStream(1000000);
                               
          



                await blobClient.DownloadToAsync(memoryStream);
            //de ce asa nu merge?
            //BinaryReader binaryReader = new BinaryReader(memoryStream);
            //var buffer = binaryReader.ReadBytes(memoryStream.Capacity);
            var buffer = memoryStream.ToArray();
          

                return buffer;
            

            
      
        }
    }
}

