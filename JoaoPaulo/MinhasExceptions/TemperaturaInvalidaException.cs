using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TDSTaskDevelopers03.JoaoPaulo.MinhasExceptions
{
    [Serializable]
    public class TemperaturaInvalidaException : Exception
    {
        // Construtor padrao
        public TemperaturaInvalidaException() : base() { }

        // Construtor para mensagem
        public TemperaturaInvalidaException(string message) : base(message) { }

        // Construtor para mensagem e exception
        public TemperaturaInvalidaException(string message, Exception exception) : base(message, exception) { }

        // Construtor para serializacao
        protected TemperaturaInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
