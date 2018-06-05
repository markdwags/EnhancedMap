﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedMap.Diagnostic
{
    public enum MESSAGE_SEVERITY
    {
        NORMAL,
        GOOD,
        WARN,
        ERROR
    }

    public struct MessageLogger
    {
        private string _text;
        
        public MessageLogger(string text, MESSAGE_SEVERITY severity)
        {
            _text = text;
            Severity = severity;
            Date = DateTime.Now;
        }

        public MESSAGE_SEVERITY Severity { get; }
        public DateTime Date { get; }

        public string ComposeMsg() => string.Format("[{0}] [{1}]: {2}", Date, Severity, _text);
    }

    public static class Logger
    {

        public static event EventHandler<MessageLogger> MessageWrited;


        public static void Log(string text)
        {
            MessageWrited.Raise(new MessageLogger(text, MESSAGE_SEVERITY.NORMAL));
        }

        public static void Good(string text)
        {
            MessageWrited.Raise(new MessageLogger(text, MESSAGE_SEVERITY.GOOD));
        }

        public static void Warn(string text)
        {
            MessageWrited.Raise(new MessageLogger(text, MESSAGE_SEVERITY.WARN));
        }

        public static void Error(string text)
        {
            MessageWrited.Raise(new MessageLogger(text, MESSAGE_SEVERITY.ERROR));
        }

    }
}
