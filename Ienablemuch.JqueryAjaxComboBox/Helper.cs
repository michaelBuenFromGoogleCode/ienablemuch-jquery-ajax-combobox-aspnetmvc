using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;
using System.Text;
using System.Globalization;

using System.Web.Script.Serialization;



/*
 * 
 * The jquery ajax combobox javascript code in folder: \Ienablemuch.Scripts\Ienablemuch.JqueryAjaxComboBox is sourced from http://www.usamimi.info/~sutara/acbox_demo/english.php
 * 
 * I modified it to fit ASP.NET MVC programming model
 * 
 * -- Michael Buen
 * */

namespace Ienablemuch.JqueryAjaxComboBox
{


    public static class Helper
    {
        // The letters are just mnemonic for partnering methods(string-based name vs expression-based name)


        /* value-less helpers... */

        // H
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,            

            string dataSourceUrl,
            string captionSrcUrl
            )
        {
            return htmlHelper.AjaxComboBox(name, null /* value */, dataSourceUrl, captionSrcUrl);
        }


        // I
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,

            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes,
            object otherJsonAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, null /* value */, dataSourceUrl, captionSrcUrl,
                HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), otherJsonAttributes);
        }

        /* ...value-less helpers */



        // G.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            object value,

            string dataSourceUrl,
            string captionSrcUrl
            )
        {
            return htmlHelper.AjaxComboBox(name, value, dataSourceUrl, captionSrcUrl, null);
        }


        // G.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string dataSourceUrl,
            string captionSrcUrl
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, null, dataSourceUrl, captionSrcUrl, null);
        }


        // I.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            object value,

            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, value, dataSourceUrl, captionSrcUrl, htmlHelper, null);
        }


        // I.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, dataSourceUrl, captionSrcUrl, htmlHelper, null);
        }



        // H.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            object value,

            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes,
            object otherJsonAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, null /* formUniqueName */, value, dataSourceUrl, captionSrcUrl,
                HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), otherJsonAttributes);
        }


        // H.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes,
            object otherJsonAttributes
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, dataSourceUrl, captionSrcUrl,
                HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), otherJsonAttributes);
        }


        // G.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            object value,

            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes,
            object otherJsonAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, null /* formUniqueName */, value, dataSourceUrl, captionSrcUrl, htmlAttributes, otherJsonAttributes);
        }



        // G.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes,
            object otherJsonAttributes
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, null, dataSourceUrl, captionSrcUrl, htmlAttributes, otherJsonAttributes);
        }



        // F.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            object value, 

            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, null /* formUniqueName */ , value, dataSourceUrl, captionSrcUrl, htmlAttributes);
        }



        // F.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes
            )
        {
            // return htmlHelper.AjaxComboBoxFor(expression, null, dataSourceUrl, captionSrcUrl, htmlAttributes);
            return htmlHelper.AjaxComboBoxFor(expression, dataSourceUrl, captionSrcUrl, htmlAttributes, null);
        }


        // A.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            string formUniqueName,
            object value,

            string dataSourceUrl,
            string captionSrcUrl
            )
        {
            return htmlHelper.AjaxComboBox(name, formUniqueName, value, dataSourceUrl, captionSrcUrl, null);
        }

        // A.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string formUniqueName,
            string dataSourceUrl,
            string captionSrcUrl
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, formUniqueName, dataSourceUrl, captionSrcUrl, null);
        }


        // B.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            string formUniqueName,
            object value,
            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, formUniqueName, value, dataSourceUrl, captionSrcUrl,
                HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        
        // B.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string formUniqueName,
            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, formUniqueName, dataSourceUrl, captionSrcUrl,
                HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }




        // C.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            string formUniqueName,
            object value,
            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, formUniqueName, value, dataSourceUrl, captionSrcUrl,
                htmlAttributes, null);
        }


        // C.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string formUniqueName,
            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, formUniqueName, dataSourceUrl, captionSrcUrl,
                htmlAttributes, null);
        }



        // D.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            string formUniqueName,
            object value,

            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes,
            object otherJsonAttributes
            )
        {
            return htmlHelper.AjaxComboBox(name, formUniqueName, value, dataSourceUrl, captionSrcUrl,
                HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), otherJsonAttributes);
        }


        // D.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string formUniqueName,
            string dataSourceUrl,
            string captionSrcUrl,
            object htmlAttributes,
            object otherJsonAttributes
            )
        {
            return htmlHelper.AjaxComboBoxFor(expression, formUniqueName, dataSourceUrl, captionSrcUrl,
                HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), otherJsonAttributes);
        }


        // E.1
        public static MvcHtmlString AjaxComboBox
            (this HtmlHelper htmlHelper, string name,
            string formUniqueName,
            object value,

            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes,
            object otherJsonAttributes
            )
        {
            
            

            return htmlHelper.AjaxComboBox(
                null /* metadata */, value, (value == null) /* useViewState */, name, formUniqueName,
                dataSourceUrl, captionSrcUrl, htmlAttributes, otherJsonAttributes);

        }        

        
        // E.2
        public static MvcHtmlString AjaxComboBoxFor<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string formUniqueName,
            string dataSourceUrl,
            string captionSrcUrl,
            IDictionary<string, object> htmlAttributes,
            object otherJsonAttributes
            )
        {
            string name = ExpressionHelper.GetExpressionText(expression);

            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = metadata.Model;
            
            
            return htmlHelper.AjaxComboBox(
                metadata, value, false /* useViewState */, name, formUniqueName,
                dataSourceUrl, captionSrcUrl, htmlAttributes, otherJsonAttributes);

        }


        // main
        private static MvcHtmlString AjaxComboBox(
            this HtmlHelper htmlHelper,
            ModelMetadata metadata, object value, 
            bool useViewData,
            string name, 
            string formUniqueName,             
            string dataSourceUrl, string captionSrcUrl, IDictionary<string, object> htmlAttributes, object otherJsonAttributes)
        {

            string id = name.Replace('.', '_');


            string valueParameter = Convert.ToString(value, CultureInfo.CurrentCulture);



            string fullName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);

            /*if (String.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("Null or empty", "name");
            }*/




            var tagBuilder = new TagBuilder("span");
            tagBuilder.MergeAttributes(htmlAttributes);
            tagBuilder.MergeAttribute("id", id);
            tagBuilder.MergeAttribute("class", "ac_area");
            /*tagBuilder.MergeAttribute("style", 
                "float: left" + 
                (tagBuilder.Attributes.ContainsKey("style") ?
                ";" + tagBuilder.Attributes["style"] : ""), true);*/
















            var sb = new StringBuilder();





            // HtmlHelper h = htmlHelper;

            string attemptedValue = (string)htmlHelper.GetModelStateValue(fullName, typeof(string));
            // string initVal = attemptedValue ?? ((useViewData) ? htmlHelper.EvalString(fullName);             
            string initVal = attemptedValue ?? (useViewData ? htmlHelper.EvalString(fullName)  : valueParameter );

            
            


            //// TODO for ComboBox's hidden

            //// If there are any errors for a named field, we add the css attribute.
            ModelState modelState;
            if (htmlHelper.ViewData.ModelState.TryGetValue(fullName, out modelState))
            {
                if (modelState.Errors.Count > 0)
                {
                    tagBuilder.AddCssClass(HtmlHelper.ValidationInputCssClassName);
                }
            }


            string html = tagBuilder.ToString();

            // tagBuilder.MergeAttributes(htmlHelper.GetUnobtrusiveValidationAttributes(fieldName, metadata));

            var z =
                    (from y in htmlHelper.GetUnobtrusiveValidationAttributes(name, metadata)
                     select new { KeyValue = "'" + y.Key + "'" + " : " + ("'" + y.Value.ToString() + "'") })
                    .Select(x => x.KeyValue).ToArray();


            

            string fieldAttributes = "";
            if (z.Length > 0)
                fieldAttributes = string.Join(" , ", z);



            string jsonString;

            if (otherJsonAttributes != null)
            {
                jsonString = new JavaScriptSerializer().Serialize(otherJsonAttributes);
                jsonString = jsonString.Substring(1, jsonString.Length - 2);
            }
            else
            {
                jsonString = "";
            }


            sb.Append(
string.Format(
@"
<script type=""text/javascript"">
$(function() {{
    
    var n = $('#{0}'{1}).ajaxComboBox('{2}', {{
        'lang' : 'en',
        'select_only' : true,
        'mini' : true,
        'init_src' : '{3}',
        'init_val' : ['{4}']
        {5}
        {6}        
    }});


    if ($.validator != undefined)    
        $.validator.unobtrusive.parseDynamicContent({7});
    
}});
</script>
"
 , id
 , formUniqueName == null ? "" : ", $('#" + formUniqueName + "')"
 , dataSourceUrl
 , captionSrcUrl
 , initVal
 , z.Length > 0 ? (", " + "other_attr : {" + fieldAttributes + "}") : ""
 , jsonString.Length > 0 ? ", " + jsonString : ""
 , formUniqueName == null ? "$('form')" : "$('#'" + formUniqueName + "')"
 )
            );




            // return new MvcHtmlString(html + @"<span style=""float: left; margin-top: 0px""></span>"  + " " + sb.ToString());
            return new MvcHtmlString(html + sb.ToString());

            // return new MvcHtmlString(tagBuilder.ToString());

        }



    }// class


    // copied from Microsoft's code, why it's internal? // Michael Buen
    internal static class AspNetMvcHelper
    {

        static internal object GetModelStateValue(this HtmlHelper htmlHelper, string key, Type destinationType)
        {
            ModelState modelState;
            if (htmlHelper.ViewData.ModelState.TryGetValue(key, out modelState))
            {
                if (modelState.Value != null)
                {
                    return modelState.Value.ConvertTo(destinationType, null /* culture */);
                }
            }
            return null;
        }

        static internal string EvalString(this HtmlHelper htmlHelper, string key)
        {
            return Convert.ToString(htmlHelper.ViewData.Eval(key), CultureInfo.CurrentCulture);
        }

    }
}