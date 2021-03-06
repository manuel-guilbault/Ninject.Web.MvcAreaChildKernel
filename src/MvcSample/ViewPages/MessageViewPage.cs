﻿using MvcSample.Models;
using Ninject;
using Ninject.Web.MvcAreaChildKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSample.ViewPages
{
    public abstract class MessageViewPage<TModel> : System.Web.Mvc.WebViewPage<TModel>
    {
        [Inject]
        public IGenericService Service { get; set; }
    }
}