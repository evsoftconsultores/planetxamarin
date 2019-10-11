using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class EnriqueIncio : IAmACommunityMember
    {
        public string FirstName => "Enrique";
        public string LastName => "Incio Chapilliquén";
        public string StateOrRegion => "Trujillo, Perú";
        public string EmailAddress => "enrique.incio@evsoftconsultores.com";
        public string ShortBioOrTagLine => "Ayudando a los desarrolladores entusiastas a aprender Xamarin.Forms, ASP.NET, azure";
        public Uri WebSite => new Uri("https://devenriqueincio.web.app");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://evsoftconsultores.com"); }
        }

        public string TwitterHandle => "EnriqueIncioCh";
        public string GravatarHash => "85d678d050f1ceef0ec57f147956d38a";
        public string GitHubHandle => "eincioch";
        public GeoPosition Position => new GeoPosition(-8.079972622967617, -79.0529681553883);
        public string FeedLanguageCode => "es";
    }
}
