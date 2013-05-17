// ********************************
// <copyright file="Log4NetTest.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace _01.Log4Net
{
    using System;
    using log4net;
    using log4net.Config;

    public class Log4NetTest
    {
        private static readonly ILog Debug =
            LogManager.GetLogger("Debug");

        private static readonly ILog Exceptions =
            LogManager.GetLogger("Exception");

        public static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            try
            {
                Debug.Info("Program Start");
                Console.WriteLine("Please input a number");
                int numner = int.Parse(Console.ReadLine());
                Console.WriteLine("Your input was a the number {0}", numner);
                Debug.Info("Program End");
            }
            catch (Exception ex)
            {
                Exceptions.Error(ex.Message);
            }
        }
    }
}
