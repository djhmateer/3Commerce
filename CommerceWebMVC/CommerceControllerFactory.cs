using CommerceWebMVC.Controllers;
using Ploeh.Samples.Commerce.Domain;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace CommerceWebMVC {
    public class CommerceControllerFactory : DefaultControllerFactory {
        private readonly Dictionary<string, Func<RequestContext, IController>> controllerMap;

        public CommerceControllerFactory(ProductRepository repository) {
            if (repository == null) {
                throw new ArgumentNullException("repository");
            }

            this.controllerMap = new Dictionary<string, Func<RequestContext, IController>>();
            this.controllerMap["Account"] = ctx => new AccountController();
            this.controllerMap["Home"] = ctx => new HomeController(repository);
        }

        public override IController CreateController(RequestContext requestContext, string controllerName) {
            return this.controllerMap[controllerName](requestContext);
        }

        public override void ReleaseController(IController controller) {
        }
    }
}