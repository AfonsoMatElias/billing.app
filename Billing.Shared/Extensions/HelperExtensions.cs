using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace Billing.Shared
{
    public static class HelperExtensions
    {
        public class UID {
            public long Id { get; set; }
            public DateTime CreatedAt { get; set; }
        }

        /// <summary>
        /// Extract the Id and CreatedAt values in 
        /// </summary>
        /// <param name="uid">The property</param>
        /// <returns>The UID</returns>
        public static UID FromUID(this string uid)
        {
            if (!uid.Contains(":")) return null;

            var splitted = uid.Split(":").ToList();

            return new UID {
                // The Id Extracted
                Id = long.Parse(splitted.FirstOrDefault()),
                // The Created Date Extracted 
                CreatedAt = new DateTime(long.Parse(splitted.LastOrDefault()))
            };
        }
        
        /// <summary>
        /// Extension to check if the a property as an attribute
        /// </summary>
        /// <param name="prop">The property</param>
        /// <param name="attrName">The attribute name</param>
        /// <returns>Bool value</returns>
        public static bool HasAttr(this PropertyInfo prop, string attrName)
        {
            // Checking if was passed a Attribute string at the end of the string
            if (!attrName.EndsWith("Attribute")) attrName += "Attribute";
            // Checking the property value
            return prop.CustomAttributes.Any(x => x.AttributeType.Name.Equals(attrName));
        }

        /// <summary>
        /// Extension to get value of an property
        /// </summary>
        /// <param name="item"></param>
        /// <param name="attrName"></param>
        /// <returns></returns>
        public static string GetAttrValue(this PropertyInfo item, string attrName)
        {

            // Checking if was passed a Attribute string at the end of the string
            if (!attrName.EndsWith("Attribute")) attrName += "Attribute";

            // Checking if has the attr 
            if (!item.HasAttr(attrName)) return null;

            // Getting the the attr data 
            var attribute = item.CustomAttributes.FirstOrDefault(x => x.AttributeType.Name.Equals(attrName));

            // Returning it
            return attribute.ConstructorArguments.FirstOrDefault().Value.ToString();
        }

        /// <summary>
        /// Extension to check if a model has a value
        /// </summary>
        /// <typeparam name="T">The Class</typeparam>
        /// <param name="model">The model that must be checked</param>
        /// <param name="value">The value to be matched</param>
        /// <returns>Bool value</returns>
        public static bool HasValue<T>(this T model, string value) where T : class
        {
            value = value.ToNull();

            // Checking the parameters
            if (value == null || model == null) return false;

            // Defining the main result
            var result = false;

            // Getting the type of the model 
            var modelType = model.GetType();

            // Looping the type props
            foreach (var p in modelType.GetProperties())
            {
                var v = p?.GetValue(model)?.ToString();

                // Checking the value is what we expect
                if (v == value)
                {
                    // Setting the result
                    result = true;
                    // Breaking the cycle
                    break;
                }
            }

            // Returning the result
            return result;
        }

        /// <summary>
        /// Extension to check if a model has a value
        /// </summary>
        /// <typeparam name="T">The Class</typeparam>
        /// <param name="model">The model that must be checked</param>
        /// <param name="value">The value to be matched</param>
        /// <param name="consts">The properties that must be checked with</param>
        /// <returns>Bool value</returns>
        public static bool HasValue<T>(this T model, string value, string consts) where T : class
        {
            consts = consts.ToNull();
            value = value.ToNull();

            // Checking the parameters
            if (value == null || model == null) return false;

            // Checking if some constraints was sent
            // Calling the HasValue Extension that has not constraints params
            if (consts == null) return HasValue(model, value);

            // Defining the main result
            var result = false;

            // Getting the type of the model 
            var modelType = model.GetType();
            var properties = modelType.GetProperties();

            // Looping the restrictions
            foreach (var constraint in consts.Split(","))
            {
                var constraintTrimmed = constraint.Trim();

                // Checking if the value is valid
                if (string.IsNullOrEmpty(constraintTrimmed)) continue;

                // Getting the prop
                var prop = properties.FirstOrDefault(p => p.Name.ToLower() == constraintTrimmed.ToLower());
                // Getting the value
                var propValue = prop?.GetValue(model)?.ToString();

                // Checking if the value is what we expect
                if (propValue == value)
                {
                    // Setting the result
                    result = true;
                    // Breaking the cycle
                    break;
                }
            }
            // Returning the value
            return result;
        }

        /// <summary>
        /// Extension to check if a model contains a value
        /// </summary>
        /// <typeparam name="T">The Class</typeparam>
        /// <param name="model">The model that must be checked</param>
        /// <param name="value">The value to be matched</param>
        /// <returns>Bool value</returns>
        public static bool ContainValue<T>(this T model, string value) where T : class
        {

            value = value.ToNull();

            // Checking the parameters
            if (value == null || model == null) return false;

            // Lowering the value
            value = value.ToLower();

            // Defining the main result
            var result = false;

            // Getting the type of the model 
            var _type_ = model.GetType();

            // Looping the type props
            foreach (var p in _type_.GetProperties())
            {
                var v = p?.GetValue(model)?.ToString();

                // Checking value
                var res = v?.ToLower().Contains(value);

                // Checking if is valid
                if (res == null) continue;

                // Checking the value is what we expect
                if ((bool)res)
                {
                    // Setting the result
                    result = true;
                    // Breaking the cycle
                    break;
                }
            }

            // Returning the value
            return result;
        }

        /// <summary>
        /// Extension to check if a model contains a value
        /// </summary>
        /// <typeparam name="T">The Class</typeparam>
        /// <param name="model">The model that must be checked</param>
        /// <param name="value">The value to be matched</param>
        /// <param name="consts">The properties that must be checked with</param>
        /// <returns>Bool value</returns>
        public static bool ContainValue<T>(this T model, string value, string consts) where T : class
        {
            consts = consts.ToNull();
            value = value.ToNull();

            // Checking the parameters
            if (value == null || model == null) return false;

            value = value.ToLower();

            // Checking if some constraints was sent
            // Calling the HasValue Extension that has not constraints params
            if (consts == null) return ContainValue(model, value);

            // Defining the main result
            var result = false;

            // Getting the type of the model 
            var _type_ = model.GetType();
            var properties = _type_.GetProperties();

            // Looping the restrictions
            foreach (var _prop_ in consts.Split(","))
            {
                var _p_ = _prop_.Trim();

                // Checking if the value is valid
                if (string.IsNullOrEmpty(_p_)) continue;

                // Getting the prop
                var prop = properties.FirstOrDefault(p => p.Name.ToLower() == _p_.ToLower());
                // Getting the value
                var v = prop?.GetValue(model)?.ToString();

                // Checking value
                var res = v?.ToLower().Contains(value);

                // Checking if is valid
                if (res == null) continue;

                // Checking the value is what we expect
                if ((bool)res)
                {
                    // Setting the result
                    result = true;
                    // Breaking the cycle
                    break;
                }
            }

            // Returning the result
            return result;
        }
        
        /// <summary>
        /// Extension to lower only the first character
        /// </summary>
        /// <param name="str">The string</param>
        /// <returns>The string transformed</returns>
        public static string ToLowerFirstChar(this string str)
            => str[0].ToString().ToLower() + str.Substring(1);

        /// <summary>
        /// Set Any string 'null' sentence to a null value
        /// </summary>
        /// <param name="str">The string input</param>
        /// <returns></returns>
        public static string ToNull(this string str)
        {
            // Checking the value
            if (str != null && str.ToLower() == "null") return null;
            // Returning the value
            return str;
        }

        /// <summary>
        /// Extension to check if a date is valid
        /// </summary>
        /// <param name="date">The Date that needs to be checked</param>
        /// <returns></returns>
        public static bool IsDate(this DateTime date)
        {
            if ( (date < new DateTime(1910, 01, 01))) return false;
            return date.ToString().Split(" ")[0] != "1/1/0001";
        }

        // Helper to manipulate an object values
        public static T IgnoreProperties<T>(this T obj, string[] ignore)
            where T : class
        {
            var result = Activator.CreateInstance<T>();
            var resultType = result.GetType();

            var type = obj.GetType();
            var _props = type.GetProperties();

            foreach (var item in _props) 
            {
                if (ignore.Any(x => x == item.Name)) continue;
                resultType.GetProperty(item.Name).SetValue(result, item.GetValue(obj));
            }
            
            return result;
        }
    }
}
