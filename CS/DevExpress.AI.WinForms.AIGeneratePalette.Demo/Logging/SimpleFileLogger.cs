using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Logging;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.Logging {
    /// <summary>
    /// A lightweight file logger that captures AI chat traffic for diagnostics.
    /// Set the ENABLE_AI_LOGGING=true environment variable (case-insensitive) before application startup to enable logging.
    /// </summary>
    public sealed class SimpleFileLogger : ILogger {
        readonly string categoryName;
        readonly string filePath;
        readonly LogLevel minLogLevel;
        static readonly DateTime LogTime = DateTime.Now;

        public static bool EnableLogging { get; } = true;

        public static string LogFileName => $"chat_log_{Process.GetCurrentProcess().Id}_{LogTime:yyyyMMdd_HHmmss}.txt";

        public static string FullPath => Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "DevExpress", "AI_GeneratePalette_Demo", LogFileName);

        static ILogger instance;
        public static ILogger Instance {
            get {
                if(instance == null) {
                    try {
                        InitializeDirectory();
                        instance = new SimpleFileLogger("Default", FullPath, LogLevel.Trace);
                    }
                    catch {
                        instance = DummyLogger.Instance;
                    }
                }
                return instance;
            }
        }

        static void InitializeDirectory() {
            var directory = Path.GetDirectoryName(FullPath);
            if(string.IsNullOrEmpty(directory)) return;
            if(!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
                return;
            }
            // Prune log files older than 10 days.
            foreach (var file in Directory.GetFiles(directory, "chat_log_*.txt")) {
                try {
                    var info = new FileInfo(file);
                    if(info.LastWriteTime < LogTime.AddDays(-10))
                        info.Delete();
                }
                catch { }
            }
        }

        SimpleFileLogger(string categoryName, string filePath, LogLevel minLogLevel) {
            this.categoryName = categoryName;
            this.filePath = filePath;
            this.minLogLevel = minLogLevel;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => logLevel >= minLogLevel && EnableLogging;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter) {
            if(!IsEnabled(logLevel) || formatter == null) return;
            string message;
            try {
                message = formatter(state, exception);
            }
            catch {
                message = state?.ToString();
            }
            var line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{logLevel}] {categoryName}: {message}";
            if(exception != null)
                line += Environment.NewLine + exception;
            try {
                File.AppendAllText(filePath, line + Environment.NewLine);
            }
            catch { /* Ignore IO errors */ }
        }
    }

    public sealed class SimpleFileLoggerProvider : ILoggerProvider {
        public static SimpleFileLoggerProvider Instance { get; } = new SimpleFileLoggerProvider();
        public ILogger CreateLogger(string categoryName) => SimpleFileLogger.Instance;
        public void Dispose() { }
    }

    sealed class DummyLogger : ILogger {
        public static readonly DummyLogger Instance = new DummyLogger();
        DummyLogger() { }
        public IDisposable BeginScope<TState>(TState state) => null;
        public bool IsEnabled(LogLevel logLevel) => false;
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter) { }
    }
}
