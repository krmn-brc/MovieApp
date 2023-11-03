using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;

namespace MovieApp.Web.Services.ToastrServices
{
    public class ToastrModel
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public ToastrType Type { get; set; }
        public ToastrModel()
        {
            
        }
        public ToastrModel(string message, string title = "Bilgilendirme", ToastrType type = ToastrType.Info)
        {
            Message = message;
            Title = title;
            Type = type;
        }
    }
}