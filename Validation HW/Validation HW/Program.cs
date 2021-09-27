using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Qst 1
            var regex1 = new Regex(@"^[dD]");
            string s = "dare";
            bool B = regex1.IsMatch(s);
            #endregion

            #region  Qst 2-3

            var regex2 = new Regex(@"[JFD]\d{6}[_][A-Z]{2}");
            s = "D098760_AS";
            B = regex2.IsMatch(s);


            #endregion

            #region QST 4

             var regex4 = new Regex(@"(y{3}|ז{4})"); 

             string s4 = "זזזז";
             s4 = regex4.Replace(s4,"");

            #endregion

            #region QST 5

            var regex5 = new Regex(@"^[A-Z]");
            string s5 = "oRn";
            B = regex5.IsMatch(s5);

            #endregion

            #region QST6

            var regex6 = new Regex(@"(abc|ABC)");
            string s6 = "iohasdABCopsajd";
            B = regex6.IsMatch(s6);


            #endregion

            #region QST7

            var regex7 = new Regex(@"^\d{10}$");
            string sss = "0525548501";
            B = regex7.IsMatch(sss);

            #endregion

            #region Qst 8

            var regex8 = new Regex(@"\d\.\d");
            string s8 = "123.0";
            B = regex8.IsMatch(s8);


            #endregion

            #region Qst 9

            var regex9 = new Regex(@"\d\.(\d{3})");
            string s9 = "1.13";
            B = regex9.IsMatch(s9);

            #endregion

            #region Qst 10

            var regex10 = new Regex(@"^.+[@](yahoo|gmail)\.(com|net|co.il)$");
            string s10 = "rayron5656@gmail.com";
            B = regex10.IsMatch(s10);

            #endregion

        }
    }
}
