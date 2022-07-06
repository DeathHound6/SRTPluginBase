﻿using System;

namespace SRTPluginBase
{
    public interface IPluginUI : IPlugin, IEquatable<IPluginUI>
    {
        /// <summary>
        /// Receives a producer-specific data structure for processing and returns a status code.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int ReceiveData(object data);

        /// <summary>
        /// Constrains this UI plugin to work with a specific producer plugin. This value may be null if there are no plugin constraints.
        /// </summary>
        string? RequiredProducer { get; }

        public new bool Equals(IPluginUI? other) => TypeName == other?.TypeName && Info.Name == other?.Info.Name;

        public new bool Equals(object? obj) => Equals(obj as IPluginUI);

        public new int GetHashCode() => HashCode.Combine(this as IPlugin, RequiredProducer);
    }
}
