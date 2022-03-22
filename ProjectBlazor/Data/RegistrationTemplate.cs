using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBlazor.Data
{
    public class RegistrationTemplate : AuthorizationTemplate
    {
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Reqistration");
            };
        }

        protected override RenderFragment Body()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Surname");              
                builder.OpenElement(2, "div");
                builder.OpenElement(3, "input");
                builder.CloseElement();
                builder.CloseElement();

                builder.AddContent(4, "Name");
                builder.OpenElement(5, "div");
                builder.OpenElement(6, "input");
                builder.CloseElement();
                builder.CloseElement();

                builder.AddContent(7, "Year");
                builder.OpenElement(8, "div");
                builder.OpenElement(9, "input");
                builder.CloseElement();
                builder.CloseElement();

                builder.AddContent(10, "Login");
                builder.OpenElement(11, "div");
                builder.OpenElement(12, "input");
                
                builder.CloseElement();
                builder.CloseElement();

                builder.AddContent(13, "Password");
                builder.OpenElement(14, "div");
                builder.OpenElement(15, "input");
                builder.AddAttribute(16, "type", "password");
                builder.CloseElement();
                builder.CloseElement();

                builder.AddContent(17, "Confirm password");
                builder.OpenElement(18, "div");
                builder.OpenElement(19, "input");
                builder.AddAttribute(20, "type", "password");
                builder.CloseElement();
                builder.CloseElement();
            };
        }

        protected override RenderFragment Footer()
        {
            int seq = 0;
            return (builder) =>
            {
                builder.OpenElement(++seq, "button");
                builder.AddAttribute(++seq, "type", "button");
                builder.AddAttribute(++seq, "class", "btn btn-success");
                builder.AddAttribute(++seq, "data-dismiss", "modal");
                builder.AddAttribute(++seq, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, Close));
                builder.AddContent(++seq, "Sign up");
                builder.CloseElement();
            };
        }
    }
}
