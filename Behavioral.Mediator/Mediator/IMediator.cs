using Behavioral.Mediator.Components;

namespace Behavioral.Mediator.Mediator
{
    internal interface IMediator
    {
        void ComponentChanged(IUIComponent component);
    }
}
