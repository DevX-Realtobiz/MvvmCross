// MvxNamedNotifyPropertyChangedEventSubscription.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore.Core;
using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Cirrious.CrossCore.WeakSubscription
{
    public class MvxNamedNotifyPropertyChangedEventSubscription<T>
        : MvxNotifyPropertyChangedEventSubscription
    {
        private readonly string _propertyName;

        public MvxNamedNotifyPropertyChangedEventSubscription(INotifyPropertyChanged source,
                                                              Expression<Func<T>> property,
                                                              EventHandler<PropertyChangedEventArgs> targetEventHandler)
            : this(source, source.GetPropertyNameFromExpression(property), targetEventHandler)
        {
        }

        public MvxNamedNotifyPropertyChangedEventSubscription(INotifyPropertyChanged source,
                                                              string propertyName,
                                                              EventHandler<PropertyChangedEventArgs> targetEventHandler)
            : base(source, targetEventHandler)
        {
            _propertyName = propertyName;
        }

        protected override Delegate CreateEventHandler()
        {
            return new PropertyChangedEventHandler((sender, e) =>
                {
                    if (string.IsNullOrEmpty(e.PropertyName)
                        || e.PropertyName == _propertyName)
                    {
                        OnSourceEvent(sender, e);
                    }
                });
        }
    }
}