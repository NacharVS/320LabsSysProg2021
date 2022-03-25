using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace AuorizRegister.Data
{
    public class Authoriz : ComponentBase
    {
        public string Name { get; set; }

        protected Guid Guid = Guid.NewGuid();
        protected string ModalDisplay = "display:none";
        protected string ModalClass = "";
        protected bool ShowBackdrop = false;

        public virtual void Open()
        {
            ModalDisplay = "display:block";
            ModalClass = "modal Show";
            ShowBackdrop = true;
            StateHasChanged();
        }

        public virtual void Close()
        {
            ModalDisplay = "display:none";
            ModalClass = "";
            ShowBackdrop = false;
            StateHasChanged();
        }

        protected virtual RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Авторизация");
            };
        }
        protected virtual RenderFragment Body()
        {
            int seq = 0;
            return (builder) =>
            {
                builder.OpenElement(++seq, "div");
                builder.AddAttribute(++seq, "style", "display: flex; justify-content: space-between; margin-bottom: 10px");
                builder.AddContent(++seq, "Login:");
                builder.OpenElement(++seq, "input");
                builder.AddAttribute(++seq, "style", "margin-right: 30px");
                builder.CloseElement();
                builder.CloseElement();
                builder.OpenElement(++seq, "div");
                builder.AddAttribute(++seq, "style", "display: flex; justify-content: space-between");
                builder.AddContent(++seq, "Password:");
                builder.OpenElement(++seq, "input");
                builder.AddAttribute(++seq, "style", "margin-right: 30px");
                builder.CloseElement();
                builder.CloseElement();
            };
        }

        protected virtual RenderFragment Footer()
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

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            int seq = 0;
            base.BuildRenderTree(builder);

            builder.OpenElement(seq, "div");
            builder.AddAttribute(++seq, "class", ModalClass);
            builder.AddAttribute(++seq, "tabindex", "-1");
            builder.AddAttribute(++seq, "role", "dialog");
            builder.AddAttribute(++seq, "style", ModalDisplay);

            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "modal-dialog");
            builder.AddAttribute(++seq, "role", "document");

            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "modal-content");

            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "modal-header");

            builder.OpenElement(++seq, "h5");
            builder.AddAttribute(++seq, "class", "modal-title");

            //header
            builder.AddContent(++seq, Header());
            builder.CloseElement();
            builder.CloseElement();

            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "modal-body");

            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "container");
            builder.AddAttribute(++seq, "margin", "20");

            //body
            builder.AddContent(++seq, Body());
            builder.CloseElement();
            builder.CloseElement();

            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "modal-footer");

            //footer
            builder.AddContent(++seq, Footer());
            builder.OpenElement(++seq, "button");
            builder.AddAttribute(++seq, "type", "button");
            builder.AddAttribute(++seq, "class", "btn btn-secondary");
            builder.AddAttribute(++seq, "data-dismiss", "modal");
            builder.AddAttribute(++seq, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, Close));
            builder.AddContent(++seq, "Close");
            builder.CloseElement();
            builder.CloseElement();
            builder.CloseElement();
            builder.CloseElement();
            builder.CloseElement();


            if (ShowBackdrop)
            {
                builder.OpenElement(++seq, "div");
                builder.AddAttribute(++seq, "class", "modal-backdrop fade show");
                builder.CloseElement();
            }
        }
    }
}
