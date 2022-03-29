using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppLists2.Data
{
    public class Registration : Authorization
    {
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Регистрация");
            };
        }

        protected override RenderFragment Body()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Логин ");
                builder.OpenElement(2, "div");
                builder.OpenElement(3, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(4, "Пароль");
                builder.OpenElement(5, "div");
                builder.OpenElement(6, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(7, " Подтвердите пароль");
                builder.OpenElement(8, "div");
                builder.OpenElement(9, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(10, "Телефон");
                builder.OpenElement(11, "div");
                builder.OpenElement(12, "input");
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
                builder.AddContent(++seq, "Ok");
                builder.CloseElement();
            };
        }
    }
}