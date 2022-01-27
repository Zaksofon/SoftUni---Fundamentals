﻿using System;
using P01_StudentSystem.Data;

namespace P01_StudentSystem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new StudentSystemContext();
            context.Database.EnsureCreated();
            context.Database.EnsureDeleted();

            Console.WriteLine("StudentSystem DB is created!");
        }
    }
}