using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.dirClasses
{
    public static class Session
    {
        //general
        public static int id { get; set; }
        public static string username { get; set; }
        public static string userType { get; set; }

        public static string firstName { get; set; }
        public static string middleName { get; set; }
        public static string lastName { get; set; }
        public static byte[] profilePicture { get; set; }

        //student
        public static int course { get; set; }
        public static string yearLevel { get; set; }
        public static string status { get; set; }

        //employee
        public static string department { get; set; }
        public static string position { get; set; }

        //machine
        public static string machineName { get; set; }
        public static string personalKey { get; set; }
        public static string remoteType { get; set; }
        public static string location { get; set; }
        public static string ipAddress { get; set; }
        public static int portNumber { get; set; }
        public static string macAddress { get; set; }
        public static string machineUsername { get; set; }
        public static string machinePassword { get; set; }
        public static string machineStatus { get; set; }

        //current academic year
        public static int academicYearID { get; set; }
        public static string semester { get; set; }
        public static string academicYear { get; set; }
    }
}
