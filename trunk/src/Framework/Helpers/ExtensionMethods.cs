﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using Castle.Components.Validator;
using System.Collections.Specialized;
using System.Web.Routing;

namespace BA.MultiMvc.Framework.Helpers
{
    public static class ExtensionMethods
    {
        public static void AddModelErrors(
          this ModelStateDictionary modelState,
          ErrorSummary errorSummary,
          IDictionary<string,string> dictionary,
          NameValueCollection data)
        {
            if (errorSummary != null && errorSummary.HasError)
            {
                foreach (var propertyInError in errorSummary.InvalidProperties)
                {
                    foreach (var message in errorSummary.GetErrorsForProperty(propertyInError))
                    {
                        try
                        {
                            modelState.AddModelError(propertyInError, dictionary[message]);
                            modelState.SetModelValue(
                                propertyInError,
                                new ValueProviderResult(GetValue(data, propertyInError),
                                    ""
                                    , System.Globalization.CultureInfo.CurrentCulture
                                        )
                                    );
                        }
                        catch (KeyNotFoundException ex)
                        {
                            throw new ApplicationException(
                                String.Format("The key {0} was not found in Dictionary", message)
                                , ex
                                );
                        }
                    }
                }
            }
        }

        public static string GetValue(this NameValueCollection collection, string index)
        {
            var originalValue = "";
            if (collection != null)
            {
                originalValue = collection[index];
            }
            return originalValue;
        }

        public static string GetLanguage(this RouteData routeData)
        {
            const string defaultValue = "en";
            return routeData.Values.ContainsKey("language") ? routeData.Values["language"].ToString().ToLower() : defaultValue;
        }

        public static string GetTenantKey(this RouteData routeData)
        {
            const string defaultValue = "Default";
            return routeData.Values.ContainsKey("tenantKey") ? routeData.Values["tenantKey"].ToString().ToCamelCased() : defaultValue;
        }

        public static string ToCamelCased(this string s)
        {
            var camelCased = s.ToLower();
            camelCased = camelCased.Remove(0, 1);
            camelCased = s.ToUpper().Substring(0, 1) + camelCased;
            return camelCased;
        }

        

        public static IList<PropertyInfo> FindProperties(this object subject, Type filter)
        {
            var ret = new List<PropertyInfo>();
            var properties = subject.GetType().GetProperties();
            foreach (var property in properties)
            {
                Type t = property.PropertyType;
                if (filter.IsAssignableFrom(t))
                    ret.Add(property);
            }
            return ret;
        }

     
    }
}
