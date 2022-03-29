using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp2.Data
{
    public class AuthorizationModal : ModalTemplate
    {
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Authorization");
            };
        }

        protected override RenderFragment Body()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Login");
                builder.OpenElement(2, "div");
                builder.OpenElement(3, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(4, "Password");
                builder.OpenElement(5, "div");
                builder.OpenElement(6, "input");
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
                builder.AddContent(++seq, "Sign-in");
                builder.CloseElement();
            };
        }
    }
}