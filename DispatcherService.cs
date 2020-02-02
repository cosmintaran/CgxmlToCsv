using System;
using System.Windows;

namespace CgxmlToCsv
{
    public static class DispatchService
    {
        public static void Invoke(Action action)
        {
            if (Application.Current == null || Application.Current.Dispatcher == null) return;
            var dispatchObject = Application.Current.Dispatcher;
            if (dispatchObject == null || dispatchObject.CheckAccess())
            {
                action();
            }
            else
            {
                dispatchObject.Invoke(action);
            }
        }

        public static void BeginInvoke(Action action)
        {
            if (Application.Current == null || Application.Current.Dispatcher == null) return;
            var dispatchObject = Application.Current.Dispatcher;
            if (dispatchObject == null || dispatchObject.CheckAccess())
            {
                action();
            }
            else
            {
                dispatchObject.BeginInvoke(action);
            }
        }
    }
}
