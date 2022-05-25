using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Inclubworld.Ventas.Transversal.Common
{
    public class Response<T>
    {
        public T Data { get; set; }
        public Boolean IsSuccess { get; set; }
        public String Message { get; set; }
        public IEnumerable<ValidationFailure> Errors { get; set; }
    }
}
