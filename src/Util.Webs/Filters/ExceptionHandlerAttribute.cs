﻿using Exceptionless.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using Util.Webs.Commons;

namespace Util.Webs.Filters {
    /// <summary>
    /// 异常处理过滤器
    /// </summary>
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute {
        /// <summary>
        /// 异常处理
        /// </summary>
        public override void OnException( ExceptionContext context ) {
            context.ExceptionHandled = true;
            context.Result = new Result( StateCode.Fail, context.Exception.GetMessage() );
        }
    }
}
