using HotBag.Web.Events.EventModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBag.Web.Events.Publisher.EmailPublisher
{
    public interface IEmailPublisher
    {
        void SentEmail(EmailModel model); 
    } 
}
