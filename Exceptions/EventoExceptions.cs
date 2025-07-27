using System;

namespace organizadordeventos.Infrastructure.Exceptions
{
    public class EventoNotFoundException : Exception
    {
        public EventoNotFoundException() : base($"Evento no encontrado")
        {
        }
        
        public EventoNotFoundException(int id) : base($"Evento con ID {id} no encontrado")
        {
        }
        
        public EventoNotFoundException(string message) : base(message)
        {
        }
        
        public EventoNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
    
    public class EventoValidationException : Exception
    {
        public EventoValidationException(string message) : base(message)
        {
        }
        
        public EventoValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}