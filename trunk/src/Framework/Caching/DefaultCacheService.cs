﻿using System;
using System.Web;

namespace BA.MultiMVC.Framework.Caching
{
    public class DefaultCacheService:ICacheService 
    {
        public DefaultCacheService()
        {
            CacheTimeSeconds = 60;
        }

        public object GetObject(string key)
        {

            return HttpRuntime.Cache[ConstructFullKeyName(key)];
        }

        public void Add(string key, object o)
        {
            DateTime expirationTime = DateTime.Now.AddSeconds(CacheTimeSeconds);
            HttpRuntime.Cache.Add(
                ConstructFullKeyName(key),
                o,
                null,
                DateTime.Now.AddSeconds(CacheTimeSeconds),
                System.Web.Caching.Cache.NoSlidingExpiration,
                System.Web.Caching.CacheItemPriority.Normal,
                null
                );
        }

        public virtual string KeyPrefix
        {
            get
            {
                return Context.TenantKey + "_" + Context.Language; 
            }
        }

        public int CacheTimeSeconds
        {
            get;
            set;
        }

        public Core.TenantContext Context
        {
            get;
            set;
        }

        private string ConstructFullKeyName(string keySuffix)
        {
            return KeyPrefix + "_" + keySuffix;
        }
    }
}