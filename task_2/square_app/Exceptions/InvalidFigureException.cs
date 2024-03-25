using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_app.Exceptions
{
    public class InvalidFigureException : Exception
    {
        public InvalidFigureException() : base() { }
        public InvalidFigureException(string message = "Invalid figure was created") : base(message) { }
        public InvalidFigureException(string message, Exception inner) : base(message, inner) { }
    }
}
