﻿using System;
using System.Runtime.Serialization;

namespace Foundation.Api.Exceptions
{
    [Serializable]
    public class AppException : Exception, IKnwoException
    {
        public AppException()
        {
        }

        public AppException(string message) : base(message)
        {
        }

        public AppException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
