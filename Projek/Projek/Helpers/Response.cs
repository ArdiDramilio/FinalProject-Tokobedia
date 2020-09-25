﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Helpers
{
    public class Response
    {
        public bool successStatus;
        public string message;
        public Response(bool successStatus)
        {
            this.successStatus = successStatus;
        }
        public Response(bool successStatus,string message)
        {
            this.successStatus = successStatus;
            this.message = message;
        }
    }
}