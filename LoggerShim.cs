using System;
using Microsoft.Extensions.Logging;

namespace Haruka.Logging.Net35Shim {
    
    public class LoggerShim : ILogger {

        public delegate void LogDelegate(string key, string formattedMessage, LogLevel logLevel, EventId eventId, Exception exception);

        public static event LogDelegate MessageLogged;
        public string Key { get; }

        public LoggerShim(string key) {
            Key = key;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) {
            MessageLogged?.Invoke(Key, formatter.Invoke(state, exception), logLevel, eventId, exception);
        }

        public bool IsEnabled(LogLevel logLevel) {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state) {
            return new DummyScope();
        }
    }

}