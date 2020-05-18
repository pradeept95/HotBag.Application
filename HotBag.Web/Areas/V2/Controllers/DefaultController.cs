using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotBag.AspNetCore.ResultWrapper.ResponseModel;
using HotBag.AspNetCore.Web.BaseController;
using HotBag.Web.Events.EventModel;
using HotBag.Web.Events.Publisher.EmailPublisher;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static HotBag.Web.Controllers.DefaultController;

namespace HotBag.Web.Areas.V2.Controllers
{
    [Area("V2")]
    public class DefaultController : BaseApiAreaController
    {
        private readonly IEmailPublisher _emailPublisher;

        public DefaultController(IEmailPublisher emailPublisher)
        {
            this._emailPublisher = emailPublisher; 
        }

        [HttpPost]
        [Route("[action]")]
        public ResultDto<EmailModel> SentEmail1([FromBody]EmailModel model)
        {
            _emailPublisher.SentEmail(model);
            return new ResultDto<EmailModel>(model);
        }
    }
}