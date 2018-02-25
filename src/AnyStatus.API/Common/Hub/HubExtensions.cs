﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace PubSub
{
    [ExcludeFromCodeCoverage]
    static public class PubSubExtensions
    {
        static private readonly Hub hub = new Hub();

        static public bool Exists<T>(this object obj)
        {
            foreach (var h in hub.handlers)
            {
                if (Equals(h.Sender.Target, obj) &&
                    typeof(T) == h.Type)
                {
                    return true;
                }
            }

            return false;
        }

        static public void Publish<T>(this object obj)
        {
            hub.Publish(obj, default(T));
        }

        static public void Publish<T>(this object obj, T data)
        {
            hub.Publish(obj, data);
        }

        static public void Subscribe<T>(this object obj, Action<T> handler)
        {
            hub.Subscribe(obj, handler);
        }

        static public void Unsubscribe(this object obj)
        {
            hub.Unsubscribe(obj);
        }

        static public void Unsubscribe<T>(this object obj)
        {
            hub.Unsubscribe(obj, (Action<T>)null);
        }

        static public void Unsubscribe<T>(this object obj, Action<T> handler)
        {
            hub.Unsubscribe(obj, handler);
        }
    }
}