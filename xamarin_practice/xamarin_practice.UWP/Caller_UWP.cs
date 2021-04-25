using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarin_practice.UWP;

[assembly: Dependency(typeof(Caller_UWP))]
namespace xamarin_practice.UWP
{
    class Caller_UWP : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("UWP에서 전화를 겁니다");
            return true;
        }
    }
}
