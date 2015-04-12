using Facebook;
using FacebookSDKExtensions.Models;
using FacebookSDKExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDKExtensions.Mappers
{
    public class FacebookAlbumMappers
    {
        public static IEnumerable<FacebookAlbum> MapToAlbums(JsonArray albumData)
        {
            var albums = new List<FacebookAlbum>();

            foreach (var album in albumData)
            {
                var albumDict = (IDictionary<string, object>)album;

                var facebookAlbum = new FacebookAlbum();
                facebookAlbum.Id = albumDict.ToString("id");
                facebookAlbum.Name = albumDict.ToString("name");
                facebookAlbum.Description = albumDict.ToString("description");
                facebookAlbum.Link = albumDict.ToString("link");
                facebookAlbum.Privacy = albumDict.ToString("privacy");
                facebookAlbum.Type = albumDict.ToString("type");
                facebookAlbum.Created = albumDict.ToDateTime("created_time");
                facebookAlbum.Updated = albumDict.ToDateTime("updated_time");
                facebookAlbum.CanUpload = albumDict.ToBool("can_upload");

                var from = (IDictionary<string, object>)albumDict["from"];
                facebookAlbum.From = new FacebookUser();
                facebookAlbum.From.Id = from.ToString("id");
                facebookAlbum.From.Name = from.ToString("name");

                albums.Add(facebookAlbum);
            }

            return albums;
        }
    }
}
