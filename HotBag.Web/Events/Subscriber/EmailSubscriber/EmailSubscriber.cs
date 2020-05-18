using HotBag.AspNetCore.Authorization;
using HotBag.AspNetCore.DI;
using HotBag.AspNetCore.EventBus;
using HotBag.Web.Events.EventModel;
using System.Threading.Tasks;

namespace HotBag.Web.Events.Subscriber.EmailSubscriber
{
    public class EmailSubscriber : SubscriberBase, IEmailSubscriber, ITransientDependencies
    {
        Subscription<EmailModel> sentEmailToken; 

        public override async Task InitializeSubscriptionAsync()
        {
            sentEmailToken = await Task.FromResult(eventBus.Subscribe<EmailModel>(this.SentEmail)); 
        } 
         
        private void SentEmail(EmailModel obj)
        {
            //sent email logics

            //unsubscribe event if necessary
           // eventBus.UnSbscribe(sentEmailToken);
        }
    }

}
