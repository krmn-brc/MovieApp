using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieApp.Web.Services.ToastrServices
{
    public static class ToastrService
    {
        private static readonly List<(DateTime Date, ToastrModel Toastr)> _toastrs
        = new List<(DateTime Date, ToastrModel Toastr)>();

        public static void AddToQueue(ToastrModel toastr)
        {
             _toastrs.Add((Date:DateTime.Now, Toastr: toastr));
        }

        public static void AddToQueue(string message, string title, ToastrType type)
        => AddToQueue(new ToastrModel(message, title, type));

        public static bool HasQueue() => throw new NotImplementedException();

        public static void RemoveQueue() => throw new NotImplementedException();

        public static void ClearAll() => _toastrs.Clear();

        public static List<(DateTime Date, ToastrModel Toastr)> ReadQueue()
        {
             return _toastrs.OrderBy(x => x.Date).ToList();
        }
        public static List<(DateTime Date, ToastrModel Toastr)> ReadAndRemoveQueue()
        {
             var list = ReadQueue();
             ClearAll();
             return list;
        }

    }
}