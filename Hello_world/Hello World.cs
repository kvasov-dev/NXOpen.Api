using System;
using System.Collections.Generic;
using System.Text;

using NXOpen;
using NXOpenUI;
using NXOpen.UF;
using NXOpen.Utilities;


namespace Hello_world
{
    public class Hello_world
    {
        private static Session theSession; //getting session
        private static Session theUFSession;
        private static Session lw; //window for displaying text information

        public static void Main()
        {
            theSession = Session.GetSession();
            var theUFSession = UFSession.GetUFSession();
            var lw = theSession.ListingWindow;

            Part workPart = theSession.Parts.Work;
            Part disPart = theSession.Parts.Display;

            lw.Open();
            lw.WriteLine("Hello, world!");


        }

        public static int GetUnloadOption(string arg)
        {
            return System.Convert.ToInt32(Session.LibraryUnloadOption.Immediately);
        }

    }
}
