﻿using System.Configuration;

namespace Video_to_Wikipedia.Helpers
{
    public class Configuration
    {
        public static string FlickrAppName
        {
            get
            {
                return ConfigurationManager.AppSettings["flickr-appname"];
            }

        }

        public static string FlickrKey
        {
            get
            {
                return ConfigurationManager.AppSettings["flickr-key"];
            }
        }

        public static string FlickrSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["flickr-secret"];
            }
        }

        public static string WikiUsername
        {
            get
            {
                return ConfigurationManager.AppSettings["wiki-username"];
            }
        }
        public static string WikiPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["wiki-password"];
            }
        }
    }
}
