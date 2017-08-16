using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Linq;
namespace Finger.Verification
{
    public class FingerRuleFor : ActionFilterAttribute
    {
        private Dictionary<string, object> rules;
        public FingerRuleFor(Dictionary<string,object> rules)
        {
            this.rules = rules;
        }
        
        public override void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
