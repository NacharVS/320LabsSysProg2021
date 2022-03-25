using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace AuorizRegister.Data
{
    public class Register : Authoriz
    {
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Авторизация");
            };
        }
        protected override RenderFragment Body()
        {
            int seq = 0;
            return (builder) =>
            {
                builder.OpenElement(++seq, "div");
                builder.AddAttribute(++seq, "style", "display: flex; justify-content: space-between; margin-bottom: 10px");
                builder.AddContent(++seq, "E-mail:");
                builder.OpenElement(++seq, "input");
                builder.AddAttribute(++seq, "style", "margin-right: 30px");
                builder.CloseElement();
                builder.CloseElement();

                builder.OpenElement(++seq, "div");
                builder.AddAttribute(++seq, "style", "display: flex; justify-content: space-between; margin-bottom: 10px");
                builder.AddContent(++seq, "Login:");
                builder.OpenElement(++seq, "input");
                builder.AddAttribute(++seq, "style", "margin-right: 30px");
                builder.CloseElement();
                builder.CloseElement();

                builder.OpenElement(++seq, "div");
                builder.AddAttribute(++seq, "style", "display: flex; justify-content: space-between; margin-bottom: 10px");
                builder.AddContent(++seq, "Password:");
                builder.OpenElement(++seq, "input");
                builder.AddAttribute(++seq, "style", "margin-right: 30px");
                builder.CloseElement();
                builder.CloseElement();

                builder.OpenElement(++seq, "div");
                builder.AddAttribute(++seq, "style", "display: flex; justify-content: space-between; margin-bottom: 10px");
                builder.AddContent(++seq, "Repeat password:");
                builder.OpenElement(++seq, "input");
                builder.AddAttribute(++seq, "style", "margin-right: 30px");
                builder.CloseElement();
                builder.CloseElement();
            };
        }
    }
}
