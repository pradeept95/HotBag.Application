using HotBag.AspNetCore.DI;
using HotBag.AspNetCore.EventBus;
using HotBag.Web.Events.EventModel;

namespace HotBag.Web.Events.Publisher.EmailPublisher
{
    public class EmailPublisher : PublisherBase, IEmailPublisher, ITransientDependencies
    {
        public void SentEmail(EmailModel model)
        {
            eventBus.Publish<EmailModel>(model);
        } 
    }

}
