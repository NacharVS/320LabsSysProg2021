using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorM.Data
{
    public class RegistrationModal : ModalTemplate
    {
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Registration");
            };
        }

        protected override RenderFragment Body()
        {
            return (builder) =>
            {
                builder.AddContent(1, "FirstName");
                builder.OpenElement(2, "div");
                builder.OpenElement(3, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(4, "LastName");
                builder.OpenElement(5, "div");
                builder.OpenElement(6, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(7, "E-mail");
                builder.OpenElement(8, "div");
                builder.OpenElement(9, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(10, "Password");
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
                builder.AddContent(++seq, "Sign-up");
                builder.CloseElement();
            };
        }
    }
}
