﻿using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MarketPlaceApp.Extensions
{
    public static class PublishedContentExtensions
    {
        public static HomePage? GetHomePage(this IPublishedContent publishedContent)
        {
            return publishedContent.AncestorOrSelf<HomePage>();
        }

        public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent)
        {
            var homePage = GetHomePage(publishedContent);
            if (homePage == null)
            {
                return null;
            }
            else
            {
                return homePage.FirstChild<SiteSettings>();
            }
        }
    }
}
