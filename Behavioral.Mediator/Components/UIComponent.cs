using Behavioral.Mediator.Mediator;

namespace Behavioral.Mediator.Components
{
    internal class UIComponent : IUIComponent
    {
        private readonly IMediator _mediator;
        public UIComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected void NotifyMediator()
        {
            _mediator.ComponentChanged(this);
        }
    }
}
