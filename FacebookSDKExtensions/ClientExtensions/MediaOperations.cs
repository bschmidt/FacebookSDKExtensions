using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookSDKExtensions.Models;
using Facebook;
using FacebookSDKExtensions.Mappers;
using FacebookSDKExtensions.Extensions;

namespace FacebookSDKExtensions.ClientExtensions
{
    public static class MediaOperations
    {
        public static PostResult CreateAlbum(this FacebookClient client, string albumName, string albumDescription)
        {
            Dictionary<string, object> albumCreateParameters = new Dictionary<string, object>();
            albumCreateParameters["message"] = albumDescription;
            albumCreateParameters["name"] = albumName;

            var result = client.Post("me/albums", albumCreateParameters) as JsonObject;

            return FacebookResultMappers.MapToPostResult(result);
        }

        public async static Task<PostResult> CreateAlbumAsync(this FacebookClient client, string albumName, string albumDescription)
        {
            Dictionary<string, object> albumCreateParameters = new Dictionary<string, object>();
            albumCreateParameters["message"] = albumDescription;
            albumCreateParameters["name"] = albumName;

            var result = await client.PostTaskAsync("me/albums", albumCreateParameters) as JsonObject;

            return FacebookResultMappers.MapToPostResult(result);
        }

        public static PostResult PostPhotoToAlbum(this FacebookClient client, string albumId, string photoUrl, string photoCaption)
        {
            var url = string.Format("{0}/photos", albumId);

            Dictionary<string, object> postPhotoParameters = new Dictionary<string, object>();
            postPhotoParameters["url"] = photoUrl;
            postPhotoParameters["message"] = photoCaption;

            var result = client.Post(url, postPhotoParameters) as JsonObject;

            return FacebookResultMappers.MapToPostResult(result);
        }

        public async static Task<PostResult> PostPhotoToAlbumAsync(this FacebookClient client, string albumId, string photoUrl, string photoCaption)
        {
            var url = string.Format("{0}/photos", albumId);

            Dictionary<string, object> postPhotoParameters = new Dictionary<string, object>();
            postPhotoParameters["url"] = photoUrl;
            postPhotoParameters["message"] = photoCaption;

            var result = await client.PostTaskAsync(url, postPhotoParameters) as JsonObject;

            return FacebookResultMappers.MapToPostResult(result);
        }

        public static IEnumerable<FacebookAlbum> GetAlbums(this FacebookClient client)
        {
            var albums = new List<FacebookAlbum>();

            JsonObject result = client.Get("/me/albums") as JsonObject;

            if (result != null)
            {
                JsonArray albumData = result["data"] as JsonArray;

                albums = FacebookAlbumMappers.MapToAlbums(albumData).ToList();
            }

            return albums;
        }

        public async static Task<IEnumerable<FacebookAlbum>> GetAlbumsAsync(this FacebookClient client)
        {
            var albums = new List<FacebookAlbum>();

            JsonObject result = await client.GetTaskAsync("/me/albums") as JsonObject;

            if (result != null)
            {
                JsonArray albumData = result["data"] as JsonArray;

                albums = FacebookAlbumMappers.MapToAlbums(albumData).ToList();
            }

            return albums;
        }
    }
}
