using System;
namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string massage) : base(massage)
        {

        }
    }
}
