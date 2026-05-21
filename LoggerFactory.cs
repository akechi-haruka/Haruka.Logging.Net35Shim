using System;
using Microsoft.Extensions.Logging;

namespace Haruka.Logging.Net35Shim {
    public class LoggerFactory {

        public static ILoggerFactory Create(Action<object> dummy) {
            return new DummyFactory();
        }

        public class DummyFactory : ILoggerFactory {
            public void Dispose() {
            }

            public ILogger CreateLogger(string categoryName) {
                return new LoggerShim(categoryName);
            }

            public void AddProvider(ILoggerProvider provider) {
                // no-op
            }
        }
    }
}