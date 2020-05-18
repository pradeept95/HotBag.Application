using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotBag.AspNetCore.ResultWrapper.ResponseModel;
using HotBag.AspNetCore.Web.BaseController;
using HotBag.Web.Events.EventModel;
using HotBag.Web.Events.Publisher.EmailPublisher;
using HotBag.Web.Microservice.Publisher;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static HotBag.Web.Controllers.DefaultController;

namespace HotBag.Web.Areas.V1.Controllers
{
    [Area("V1")]
    public class DefaultController : BaseApiAreaController
    {
        private readonly IEmailPublisher _emailPublisher;
        private readonly IMSEmailPublisher _iMSEmailPublisher;

        public DefaultController(IEmailPublisher emailPublisher, IMSEmailPublisher iMSEmailPublisher)
        {
            this._emailPublisher = emailPublisher;
            this._iMSEmailPublisher = iMSEmailPublisher;
        }

        [HttpPost]
        [Route("[action]")]
        public ResultDto<EmailModel> SentEmail([FromBody]EmailModel model)
        {
            _emailPublisher.SentEmail(model);

            _iMSEmailPublisher.PublishMessage(model.Message);
            return new ResultDto<EmailModel>(model);
        }
    }
}