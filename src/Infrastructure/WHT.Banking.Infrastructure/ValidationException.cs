using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHT.Banking.Infrastructure
{
    public class ValidationException : Exception
    {
        public ValidationException()
        {

        }

        public IList<ValidationResult> ValidationResults { get; }

        public Type TargetType { get; }

        public override string Message
        {
            get
            {
                return string.Concat(TargetType.ToString(), ": ", string.Join(';', ValidationResults.Select(x => $"{x.ErrorMessage}")));
            }
        }
    }
}
